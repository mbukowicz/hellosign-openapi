# TemplateUpdateFilesRequest



## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| `client_id` | ```str``` |  Client id of the app you&#39;re using to update this template.  |  |
| `file` | ```[file_type]``` |  Use `file[]` to indicate the uploaded file(s) to use for the template.<br><br>This endpoint requires either **file** or **file_url[]**, but not both.  |  |
| `file_url` | ```[str]``` |  Use `file_url[]` to have Dropbox Sign download the file(s) to use for the template.<br><br>This endpoint requires either **file** or **file_url[]**, but not both.  |  |
| `message` | ```str``` |  The new default template email message.  |  |
| `subject` | ```str``` |  The new default template email subject.  |  |
| `test_mode` | ```bool``` |  Whether this is a test, the signature request created from this draft will not be legally binding if set to `true`. Defaults to `false`.  |  [default to False] |


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

