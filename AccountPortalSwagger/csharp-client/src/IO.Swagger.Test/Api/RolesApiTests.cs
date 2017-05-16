/* 
 * Account Management REST API
 *
 * The Account Management REST API can be used to manage user accounts, roles, and securables for applications on the Platform. The endpoints of this API allow you to perform the same the functionality of the Platform's Account Portal for your Tenant's applications.   For more information, see our documentation on the [Account Portal](/current/account).     ## Authentication    Before making a request, you must be authenticated. Follow these instuctions [to get authenticated](/restapi/accountmanagement/v1/authentication). ## Making a Request   ### Prerequisites    * Installed Platform of version 6.6.0 or later    * An active user account assigned to an active Tenant Account or Developer Team    * Authentication token   ### Request URL    All requests must use **https**.       The URL for every request you make is the URL of your Platform followed by \"/account\" and the path structure of the endpoint. For example, if your Platform URL is https://apps.apprenda.harp and you want to get a list of all user accounts for your Tenant, the request URL will be https://apps.apprenda.harp/account/api/v1/users.     For more information, see our documentation on [using api resources](/restapi/accountmanagement/v1/using-resources) and [finding your Cloud URI](/current/clouduri).    ### Request Headers  Your authenication token must be passed in the header of all requests using the key **ApprendaSessionToken** (not case sensitive).    
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing RolesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RolesApiTests
    {
        private RolesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RolesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RolesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RolesApi
            //Assert.IsInstanceOfType(typeof(RolesApi), instance, "instance is a RolesApi");
        }

        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesDelete
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //string securableId = null;
            //List<string> body = null;
            //instance.ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesDelete(applicationVersionKey, securableId, body);
            
        }
        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesGet
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //string securableId = null;
            //var response = instance.ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesGet(applicationVersionKey, securableId);
            //Assert.IsInstanceOf<UnpagedResourceBaseRole> (response, "response is UnpagedResourceBaseRole");
        }
        
        /// <summary>
        /// Test ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesPost
        /// </summary>
        [Test]
        public void ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string applicationVersionKey = null;
            //string securableId = null;
            //List<string> body = null;
            //instance.ApiV1ApplicationVersionsApplicationVersionKeySecurablesSecurableIdRolesPost(applicationVersionKey, securableId, body);
            
        }
        
        /// <summary>
        /// Test ApiV1RolesGet
        /// </summary>
        [Test]
        public void ApiV1RolesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiV1RolesGet();
            //Assert.IsInstanceOf<UnpagedResourceBaseRole> (response, "response is UnpagedResourceBaseRole");
        }
        
        /// <summary>
        /// Test ApiV1RolesPost
        /// </summary>
        [Test]
        public void ApiV1RolesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Role body = null;
            //var response = instance.ApiV1RolesPost(body);
            //Assert.IsInstanceOf<Role> (response, "response is Role");
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdDelete
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //instance.ApiV1RolesRoleIdDelete(roleId);
            
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdGet
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //var response = instance.ApiV1RolesRoleIdGet(roleId);
            //Assert.IsInstanceOf<Role> (response, "response is Role");
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdPut
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //Role body = null;
            //var response = instance.ApiV1RolesRoleIdPut(roleId, body);
            //Assert.IsInstanceOf<Role> (response, "response is Role");
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdRolesDelete
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdRolesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //List<string> body = null;
            //instance.ApiV1RolesRoleIdRolesDelete(roleId, body);
            
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdRolesGet
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdRolesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //var response = instance.ApiV1RolesRoleIdRolesGet(roleId);
            //Assert.IsInstanceOf<UnpagedResourceBaseRole> (response, "response is UnpagedResourceBaseRole");
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdRolesPost
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdRolesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //List<string> roleIds = null;
            //instance.ApiV1RolesRoleIdRolesPost(roleId, roleIds);
            
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdSecurablesGet
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdSecurablesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //var response = instance.ApiV1RolesRoleIdSecurablesGet(roleId);
            //Assert.IsInstanceOf<UnpagedResourceBaseSecurable> (response, "response is UnpagedResourceBaseSecurable");
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdUsersDelete
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdUsersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //List<string> body = null;
            //instance.ApiV1RolesRoleIdUsersDelete(roleId, body);
            
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdUsersGet
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdUsersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //var response = instance.ApiV1RolesRoleIdUsersGet(roleId);
            //Assert.IsInstanceOf<UnpagedResourceBaseUser> (response, "response is UnpagedResourceBaseUser");
        }
        
        /// <summary>
        /// Test ApiV1RolesRoleIdUsersPost
        /// </summary>
        [Test]
        public void ApiV1RolesRoleIdUsersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //List<string> body = null;
            //instance.ApiV1RolesRoleIdUsersPost(roleId, body);
            
        }
        
        /// <summary>
        /// Test ApiV1UserRolesDelete
        /// </summary>
        [Test]
        public void ApiV1UserRolesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //List<string> body = null;
            //instance.ApiV1UserRolesDelete(userId, body);
            
        }
        
        /// <summary>
        /// Test ApiV1UserRolesGet
        /// </summary>
        [Test]
        public void ApiV1UserRolesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.ApiV1UserRolesGet(userId);
            //Assert.IsInstanceOf<UnpagedResourceBaseRole> (response, "response is UnpagedResourceBaseRole");
        }
        
        /// <summary>
        /// Test ApiV1UserRolesPost
        /// </summary>
        [Test]
        public void ApiV1UserRolesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //List<string> body = null;
            //instance.ApiV1UserRolesPost(userId, body);
            
        }
        
    }

}
