﻿using AutoMapper;
using HelpingHands_API.Models;
using HelpingHands_API.Repository.IRepostiory;
    [Route("api/v{version:apiVersion}/[Controller]/[Action]")]
    [ApiController]


		[HttpGet(Name = "GetAmenitys")]
		[ResponseCache(CacheProfileName = "Default30")]
        //[ProducesResponseType(200, Type =typeof(CategoryDTO))]
        //        [ResponseCache(Location =ResponseCacheLocation.None,NoStore =true)]
        public async Task<ActionResult<APIResponse>> GetAmenity(int id)
                term = string.IsNullOrEmpty(term) ? "" : term.ToLower();

                AmenityIndexVM amenityIndexVM = new AmenityIndexVM();
                IEnumerable<Amenity> list = await _unitOfWork.Amenity.GetAllAsync(includeProperties: "FirstCategory");
                var LIST = list.OrderBy(a => a.AmenityName).ToList();
                var List = _mapper.Map<List<AmenityDTO>>(LIST);

                amenityIndexVM.NameSortOrder = string.IsNullOrEmpty(orderBy) ? "countryName_desc" : "";

                if (!string.IsNullOrEmpty(term))
                {
                    List = List.Where(u => u.AmenityName.ToLower().Contains(term) ||
                    u.FirstCategory.FirstCategoryName.ToLower().Contains(term)).ToList();
                }

                switch (orderBy)
                {
                    case "countryName_desc":
                        List = List.OrderByDescending(a => a.AmenityName).ToList();
                        break;

                    default:
                        List = List.OrderBy(a => a.AmenityName).ToList();
                        break;
                }
                int totalRecords = List.Count();
                int pageSize = 10;
                int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
                List = List.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                // current=1, skip= (1-1=0), take=5 
                // currentPage=2, skip (2-1)*5 = 5, take=5 ,
                amenityIndexVM.amenities = List;
                amenityIndexVM.CurrentPage = currentPage;
                amenityIndexVM.TotalPages = totalPages;
                amenityIndexVM.Term = term;
                amenityIndexVM.PageSize = pageSize;
                amenityIndexVM.OrderBy = orderBy;

                _response.Result = _mapper.Map<AmenityIndexVM>(amenityIndexVM);
        // [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        {

                if (await _unitOfWork.Amenity.GetAsync(u => u.AmenityName.Trim().ToLower() == createDTO.AmenityName.Trim().ToLower() && u.FirstCategoryId == createDTO.FirstCategoryId) != null)

        public async Task<ActionResult<APIResponse>> DeleteAmenity(int id)