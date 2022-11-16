"""
    Dropbox Sign API

    Dropbox Sign v3 API  # noqa: E501

    The version of the OpenAPI document: 3.0.0
    Contact: apisupport@hellosign.com
    Generated by: https://openapi-generator.tech
"""


from setuptools import setup, find_packages  # noqa: H301

NAME = "hellosign-python-sdk"
VERSION = "6.0.0-beta22.22"
# To install the library, run the following
#
# python setup.py install
#
# prerequisite: setuptools
# http://pypi.python.org/pypi/setuptools

REQUIRES = [
  "urllib3 >= 1.25.3",
  "python-dateutil",
]

setup(
    name=NAME,
    version=VERSION,
    description="Dropbox Sign API",
    author="OpenAPI Generator community",
    author_email="apisupport@hellosign.com",
    url="",
    keywords=["OpenAPI", "OpenAPI-Generator", "Dropbox Sign API"],
    python_requires=">=3.7",
    install_requires=REQUIRES,
    packages=find_packages(exclude=["test", "tests"]),
    include_package_data=True,
    license="MIT",
    long_description="""\
    Dropbox Sign v3 API  # noqa: E501
    """
)
