﻿using AutoMapper;
using HelpingHands_API.Models;
using HelpingHands_API.Repository.IRepostiory;
	[Route("api/v{version:apiVersion}/[Controller]/[Action]")]
	[ApiController]


		[HttpGet(Name = "GetServices")]
		[ResponseCache(CacheProfileName = "Default30")]


        [HttpGet(Name = "ServiceByPagination")]
                term = string.IsNullOrEmpty(term) ? "" : term.ToLower();

                ServiceIndexVM serviceIndexVM = new ServiceIndexVM();
                IEnumerable<Service> list = await _unitOfWork.Service.GetAllAsync(includeProperties: "FirstCategory");

                var List = _mapper.Map<List<ServiceDTO>>(list);

                serviceIndexVM.NameSortOrder = string.IsNullOrEmpty(orderBy) ? "countryName_desc" : "";

                if (!string.IsNullOrEmpty(term))
                {
                    List = List.Where(u => u.ServiceName.ToLower().Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    u.FirstCategory.FirstCategoryName.ToLower().Contains(term, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                switch (orderBy)
                {
                    case "countryName_desc":
                        List = List.OrderByDescending(a => a.ServiceName).ToList();
                        break;

                    default:
                        List = List.OrderBy(a => a.ServiceName).ToList();
                        break;
                }
                int totalRecords = List.Count();
                int pageSize = 10;
                int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
                List = List.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                // current=1, skip= (1-1=0), take=5 
                // currentPage=2, skip (2-1)*5 = 5, take=5 ,
                serviceIndexVM.services = List;
                serviceIndexVM.CurrentPage = currentPage;
                serviceIndexVM.TotalPages = totalPages;
                serviceIndexVM.Term = term;
                serviceIndexVM.PageSize = pageSize;
                serviceIndexVM.OrderBy = orderBy;

                _response.Result = _mapper.Map<ServiceIndexVM>(serviceIndexVM);
        //[ProducesResponseType(200, Type =typeof(CategoryDTO))]
        //        [ResponseCache(Location =ResponseCacheLocation.None,NoStore =true)]
        public async Task<ActionResult<APIResponse>> GetService(int id)


		[HttpPost(Name = "CreateService")]
		// [Authorize(Roles = "admin")]
		[ProducesResponseType(StatusCodes.Status201Created)]
             
                if (await _unitOfWork.Service.GetAsync(u => u.ServiceName.Trim().ToLower() == createDTO.ServiceName.Trim().ToLower() && u.FirstCategoryId == createDTO.FirstCategoryId) != null)

        public async Task<ActionResult<APIResponse>> DeleteService(int id)
                if (await _unitOfWork.Service.GetAsync(u => u.ServiceName.ToLower() == updateDTO.ServiceName.ToLower() && u.FirstCategoryId == updateDTO.FirstCategoryId && u.Id != updateDTO.Id) != null)