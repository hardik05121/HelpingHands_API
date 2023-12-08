﻿

using HelpingHands_Utility;
using HelpingHands_Web.Models;
using HelpingHands_Web.Models.DTO;
using HelpingHands_Web.Service.IService;

namespace HelpingHands_Web.Service

        public Task<T> CountryByLazyLoading<T>(int pageNum, string token)
            string apiUrl = $"{categoryUrl}/api/v1/CountryAPI/CountryByLazyLoading?pageNum={pageNum}";
        }

        public Task<T> CountryByPagination<T>(string term, string orderBy, int currentPage, string token)
            //string apiUrl = $"{carUrl}/api/v1/StateAPI/GetStatesData/{Id}/{search}/{pageSize}/{pageNumber}";
            string apiUrl = $"{categoryUrl}/api/v1/CountryAPI/CountryByPagination?term={term}&orderBy={orderBy}&currentPage={currentPage}";

        }