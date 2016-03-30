package com.liferay.mobile.sdk.v62.sclicense;

import com.liferay.mobile.sdk.Call;
import com.liferay.mobile.sdk.http.Response;
import com.liferay.mobile.sdk.annotation.Param;
import com.liferay.mobile.sdk.annotation.Path;
import java.lang.String;
import org.json.JSONObject;

@Path("/sclicense")
public interface SCLicenseService {
  @Path("/add-license")
  Call<JSONObject> addLicense(@Param("name") String name, @Param("url") String url, @Param("openSource") boolean openSource, @Param("active") boolean active, @Param("recommended") boolean recommended);

  @Path("/delete-license")
  Call<Response> deleteLicense(@Param("licenseId") long licenseId);

  @Path("/get-license")
  Call<JSONObject> getLicense(@Param("licenseId") long licenseId);

  @Path("/update-license")
  Call<JSONObject> updateLicense(@Param("licenseId") long licenseId, @Param("name") String name, @Param("url") String url, @Param("openSource") boolean openSource, @Param("active") boolean active, @Param("recommended") boolean recommended);
}