﻿using AutoMapper;
using POS_WebAPI.Models.Constant;
using POS_WebAPI.Models.EntityModel;
using POS_WebAPI.Models.RequestModel.Company;

namespace POS_WebAPI.DataMapper
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile() 
        {
            CreateMap<CompanyUpdateReq, Company>()
                .ForMember(des => des.Name, op => op.Condition(e => e.Name != null))
                .ForMember(des => des.System_Id, op => op.Condition(e => e.System_Id != null))
                .ForMember(des => des.Email, op => op.Condition(e => e.Email != null))
                .ForMember(des => des.Contact, op => op.Condition(e => e.Contact != null))
                .ForMember(des => des.Image, op => op.Condition(e => e.Image != null))
                .ForMember(des => des.Website, op => op.Condition(e => e.Website != null))
                .ForMember(des => des.Address, op => op.Condition(e => e.Address != null))
                .ForMember(des => des.Status, op => op.Condition(e => e.Status != null))
                ;
        }

    }
}
