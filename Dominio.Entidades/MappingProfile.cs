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

           // mapeo

            CreateMap<Producto, ProductoViewModel>().
                ForMember(dest => dest.IIdproducto, opt => opt.MapFrom(src => src.Idproducto)).
                ForMember(dest => dest.vNombrecodigo, opt => opt.MapFrom(src => src.Nombre + " " + src.Codigo)).
                ForMember(dest => dest.iStock, opt => opt.MapFrom(src => src.Stock)).
                ForMember(dest => dest.bEstado, opt => opt.MapFrom(src => src.Estado));

            CreateMap<ProductoViewModel, Producto>().
            ForMember(dest => dest.Idproducto, opt => opt.MapFrom(src => src.IIdproducto)).
            ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.vNombre)).
            ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.vCodigo)).
            ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.iStock)).
            ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.bEstado));
        }
    }
}
