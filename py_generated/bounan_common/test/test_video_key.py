# coding: utf-8

"""
    Bounan.Common models

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

    The version of the OpenAPI document: 2.0.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from bounan_common.models.video_key import VideoKey

class TestVideoKey(unittest.TestCase):
    """VideoKey unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> VideoKey:
        """Test VideoKey
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `VideoKey`
        """
        model = VideoKey()
        if include_optional:
            return VideoKey(
                my_anime_list_id = 56,
                dub = '',
                episode = 56
            )
        else:
            return VideoKey(
                my_anime_list_id = 56,
                dub = '',
                episode = 56,
        )
        """

    def testVideoKey(self):
        """Test VideoKey"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
