import org.hellosign.openapi.ApiClient;
import org.hellosign.openapi.ApiException;
import org.hellosign.openapi.Configuration;
import org.hellosign.openapi.api.*;
import org.hellosign.openapi.auth.HttpBasicAuth;
import org.hellosign.openapi.model.*;

public class Example {
    public static void main(String[] args) {
        ApiClient defaultClient = Configuration.getDefaultApiClient();

        // Configure HTTP basic authorization: api_key
        HttpBasicAuth api_key = (HttpBasicAuth) defaultClient.getAuthentication("api_key");
        api_key.setUsername("YOUR_API_KEY");

        // or, configure Bearer (JWT) authorization: oauth2
/*      HttpBearerAuth oauth2 = (HttpBearerAuth) defaultClient.getAuthentication("oauth2");
        oauth2.setBearerToken("YOUR_ACCESS_TOKEN");*/

        TemplateApi apiInstance = new TemplateApi(defaultClient);

        String templateId = "21f920ec2b7f4b6bb64d3ed79f26303843046536";

        TemplateRemoveUserRequest request = new TemplateRemoveUserRequest().emailAddress("george@hellosign.com");

        try {
            TemplateGetResponse result = apiInstance.templateRemoveUser(templateId, request);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling AccountApi#accountCreate");
            System.err.println("Status code: " + e.getCode());
            System.err.println("Reason: " + e.getResponseBody());
            System.err.println("Response headers: " + e.getResponseHeaders());
            e.printStackTrace();
        }
    }
}