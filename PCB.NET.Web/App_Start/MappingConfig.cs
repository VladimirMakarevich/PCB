﻿using AutoMapper;
using PCB.NET.Domain.Model.WorkshopPCB.Employee;
using PCB.NET.Domain.Model.WorkshopPCB.Machine;
using PCB.NET.Domain.Model.WorkshopPCB.Map;
using PCB.NET.Domain.Model.WorkshopPCB.Warehouse;
using PCB.NET.Web.Areas.PCB.Models.EmployeeViewModel;
using PCB.NET.Web.Areas.PCB.Models.MachineViewModel;
using PCB.NET.Web.Areas.PCB.Models.MapViewModel;
using PCB.NET.Web.Areas.PCB.Models.WarehouseViewModel;

namespace PCB.NET.Web
{
    public class MappingConfig
    {
        #region Fields
        internal static MapperConfiguration MapperConfigGasBalloon;
        internal static MapperConfiguration MapperConfigHanging;
        internal static MapperConfiguration MapperConfigSMD;
        internal static MapperConfiguration MapperConfigOtherStore;
        internal static MapperConfiguration MapperConfigSize;
        internal static MapperConfiguration MapperConfigPackage;
        internal static MapperConfiguration MapperConfigBoard;
        internal static MapperConfiguration MapperConfigEmployee;
        internal static MapperConfiguration MapperConfigDoneWork;
        internal static MapperConfiguration MapperConfigPosition;
        internal static MapperConfiguration MapperConfigEbso;
        internal static MapperConfiguration MapperConfigDvc;
        internal static MapperConfiguration MapperConfigMap;
        internal static MapperConfiguration MapperConfigMapBoard;
        #endregion

        #region Mapping
        public static void RegisterMapping()
        {
            MapperConfigGasBalloon = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GasBalloon, GasBalloonViewModel>().ReverseMap();

            });
            MapperConfigHanging = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hanging, HangingViewModel>().ReverseMap();

            });
            MapperConfigSMD = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<SMD, SMDViewModel>().ReverseMap();
            });
            MapperConfigOtherStore = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<OtherStore, OtherStoreViewModel>().ReverseMap();
            });
            MapperConfigSize = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<Size, SizeViewModel>().ReverseMap();
            });
            MapperConfigPackage = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Package, PackageViewModel>().ReverseMap();
            });
            MapperConfigBoard = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Board, BoardViewModel>().ReverseMap();
            });
            MapperConfigEmployee = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            });
            MapperConfigPosition = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Position, PositionViewModel>().ReverseMap();
            });
            MapperConfigDoneWork = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DoneWork, DoneWorkViewModel>().ReverseMap();
            });
            MapperConfigDvc = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Dvc, DvcViewModel>().ReverseMap();
            });
            MapperConfigEbso = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Ebso, EbsoViewModel>().ReverseMap();
            });
            MapperConfigMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Map, MapViewModel>().ReverseMap();
            });
            MapperConfigMapBoard = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MapBoard, MapBoardViewModel>().ReverseMap();
            });
        }
        #endregion
    }
}