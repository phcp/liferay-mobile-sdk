/**
 * Copyright (c) 2000-present Liferay, Inc. All rights reserved.
 *
 * This library is free software; you can redistribute it and/or modify it under
 * the terms of the GNU Lesser General Public License as published by the Free
 * Software Foundation; either version 2.1 of the License, or (at your option)
 * any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
 * details.
 */

#if defined(LIFERAY_MOBILE_SDK_FRAMEWORK) && defined(LIFERAY_MOBILE_SDK_APP)
    @import LRMobileSDK;
#else
    #import "LRBaseService.h"
#endif

/**
 * @author Bruno Farache
 */
@interface LRResourceBlockService_v71 : LRBaseService

- (void)addCompanyScopePermissionWithScopeGroupId:(long long)scopeGroupId companyId:(long long)companyId name:(NSString *)name roleId:(long long)roleId actionId:(NSString *)actionId error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)addGroupScopePermissionWithScopeGroupId:(long long)scopeGroupId companyId:(long long)companyId groupId:(long long)groupId name:(NSString *)name roleId:(long long)roleId actionId:(NSString *)actionId error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)addIndividualScopePermissionWithCompanyId:(long long)companyId groupId:(long long)groupId name:(NSString *)name primKey:(long long)primKey roleId:(long long)roleId actionId:(NSString *)actionId error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)removeAllGroupScopePermissionsWithScopeGroupId:(long long)scopeGroupId companyId:(long long)companyId name:(NSString *)name roleId:(long long)roleId actionId:(NSString *)actionId error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)removeCompanyScopePermissionWithScopeGroupId:(long long)scopeGroupId companyId:(long long)companyId name:(NSString *)name roleId:(long long)roleId actionId:(NSString *)actionId error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)removeGroupScopePermissionWithScopeGroupId:(long long)scopeGroupId companyId:(long long)companyId groupId:(long long)groupId name:(NSString *)name roleId:(long long)roleId actionId:(NSString *)actionId error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)removeIndividualScopePermissionWithCompanyId:(long long)companyId groupId:(long long)groupId name:(NSString *)name primKey:(long long)primKey roleId:(long long)roleId actionId:(NSString *)actionId error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)setCompanyScopePermissionsWithScopeGroupId:(long long)scopeGroupId companyId:(long long)companyId name:(NSString *)name roleId:(long long)roleId actionIds:(NSArray *)actionIds error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)setGroupScopePermissionsWithScopeGroupId:(long long)scopeGroupId companyId:(long long)companyId groupId:(long long)groupId name:(NSString *)name roleId:(long long)roleId actionIds:(NSArray *)actionIds error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)setIndividualScopePermissionsWithCompanyId:(long long)companyId groupId:(long long)groupId name:(NSString *)name primKey:(long long)primKey roleId:(long long)roleId actionIds:(NSArray *)actionIds error:(NSError **)error CONVERT_ERROR_TO_THROWS;
- (void)setIndividualScopePermissionsWithCompanyId:(long long)companyId groupId:(long long)groupId name:(NSString *)name primKey:(long long)primKey roleIdsToActionIds:(NSDictionary *)roleIdsToActionIds error:(NSError **)error CONVERT_ERROR_TO_THROWS;

@end