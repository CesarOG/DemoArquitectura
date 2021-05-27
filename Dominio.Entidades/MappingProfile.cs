using AutoMapper;
using Dominio.Entidades.Model;
using Dominio.Entidades.ViewModel;

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>().
                ForMember(dest => dest.nId, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.vNombreCompleto, opt => opt.MapFrom(src => src.Nombre + " " + src.ApellidoPaterno + " " + src.ApellidoMaterno)).
                ForMember(dest => dest.nEdad, opt => opt.MapFrom(src => src.Edad)).
                ForMember(dest => dest.bEstado, opt => opt.MapFrom(src => src.Estado));

            CreateMap<ClienteViewModel, Cliente>().
              ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId)).
              ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.vNombre)).
              ForMember(dest => dest.ApellidoPaterno, opt => opt.MapFrom(src => src.vApePaterno)).
              ForMember(dest => dest.ApellidoMaterno, opt => opt.MapFrom(src => src.vApeMaterno)).
              ForMember(dest => dest.Edad, opt => opt.MapFrom(src => src.nEdad)).
              ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.bEstado));
        }
    }
}
