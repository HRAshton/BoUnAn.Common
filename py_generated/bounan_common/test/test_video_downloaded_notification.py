# coding: utf-8

"""
    Bounan.Common models

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

    The version of the OpenAPI document: 2.0.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from bounan_common.models.video_downloaded_notification import VideoDownloadedNotification

class TestVideoDownloadedNotification(unittest.TestCase):
    """VideoDownloadedNotification unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> VideoDownloadedNotification:
        """Test VideoDownloadedNotification
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `VideoDownloadedNotification`
        """
        model = VideoDownloadedNotification()
        if include_optional:
            return VideoDownloadedNotification(
                my_anime_list_id = 56,
                dub = '',
                episode = 56,
                message_id = 56
            )
        else:
            return VideoDownloadedNotification(
                my_anime_list_id = 56,
                dub = '',
                episode = 56,
        )
        """

    def testVideoDownloadedNotification(self):
        """Test VideoDownloadedNotification"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()