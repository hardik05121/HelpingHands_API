﻿

using HelpingHands_Utility;
using HelpingHands_Web.Models;
using HelpingHands_Web.Models.DTO;
using HelpingHands_Web.Service.IService;

namespace HelpingHands_Web.Service{    public class FirstCategoryService : BaseService, IFirstCategoryService    {        private readonly IHttpClientFactory _clientFactory;        private string categoryUrl;        public FirstCategoryService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)        {            _clientFactory = clientFactory;            categoryUrl = configuration.GetValue<string>("ServiceUrls:HelpingHandAPI");        }        public Task<T> CreateAsync<T>(FirstCategoryCreateDTO dto, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.POST,                Data = dto,                Url = categoryUrl + "/api/v1/firstCategoryAPI/CreateFirstCategory",                Token = token            });        }        public Task<T> DeleteAsync<T>(int id, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.DELETE,                Url = categoryUrl + "/api/v1/firstCategoryAPI/DeleteFirstCategory/" + id,                Token = token            });        }        public Task<T> GetAllAsync<T>(string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = categoryUrl + "/api/v1/firstCategoryAPI/GetFirstCategorys",                Token = token            });        }

        public Task<T> FirstCategoryByPagination<T>(string term, string orderBy, int currentPage, string token)        {
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{categoryUrl}/api/v1/firstCategoryAPI/FirstCategoryByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = apiUrl,                Token = token            });

        }        public Task<T> GetAsync<T>(int id, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.GET,                Url = categoryUrl + "/api/v1/firstCategoryAPI/GetFirstCategory/" + id,                Token = token            });        }        public Task<T> UpdateAsync<T>(FirstCategoryUpdateDTO dto, string token)        {            return SendAsync<T>(new APIRequest()            {                ApiType = SD.ApiType.PUT,                Data = dto,                Url = categoryUrl + "/api/v1/firstCategoryAPI/UpdateFirstCategory/" + dto.Id,                Token = token            });        }    }}
