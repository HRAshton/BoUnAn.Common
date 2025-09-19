import { InvokeCommand, LambdaClient } from '@aws-sdk/client-lambda';

import { assert } from './assert';

const lambdaClient = new LambdaClient({});


export const makeLambdaRequest = async <TRequest, TResponse>(functionName: string, payload: TRequest): Promise<TResponse> => {
    console.log(`Making request to Lambda function ${functionName} with payload: `, payload);

    const message = JSON.stringify(payload);
    console.log('Sending request: ', message);

    const response = await lambdaClient.send(new InvokeCommand({
        FunctionName: functionName,
        Payload: message,
    }));
    console.log('Request sent: ', response);

    assert(!!response.Payload, 'Response payload is empty');

    const result: TResponse = JSON.parse(Buffer.from(response.Payload!).toString());
    console.log('Received response: ', result);

    return result;
}