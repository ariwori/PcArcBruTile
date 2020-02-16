﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BruTile;
using BruTile.Predefined;
using BruTile.Web;
using BrutileArcGIS.Lib;

namespace BrutileArcGIS.lib
{
    public class ChinaConfig : IConfig
    {

        private readonly EnumBruTileLayer _mapType = EnumBruTileLayer.GaodeRoad;

        public ChinaConfig(EnumBruTileLayer mapType)
        {
            _mapType = mapType;
        }

        public ITileSource CreateTileSource()
        {
            if (_mapType == EnumBruTileLayer.GaodeRoad)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20), 
                        "http://webrd0{s}.is.autonavi.com/appmaptile?lang=zh_cn&size=1&scale=1&style=7&x={x}&y={y}&z={z}", 
                        new[] {"1", "2", "3","4"}, name: _mapType.ToString());
            }
            else if (_mapType==EnumBruTileLayer.GaodeArial)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "http://webst0{s}.is.autonavi.com/appmaptile?style=6&x={x}&y={y}&z={z}",
                        new[] { "1", "2", "3","4" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.GaodeHybrid)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "http://webst0{s}.is.autonavi.com/appmaptile?style=8&x={x}&y={y}&z={z}",
                        new[] { "1", "2", "3","4" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.GaodeTraffic)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "http://123.57.79.15/Service/Traffic.ashx?zoom={z}&x={x}&y={y}",
                        new[] { "1", "2", "3", "4" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.TDTRoad)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "https://t{s}.tianditu.gov.cn/DataServer?T=vec_w&&x={x}&y={y}&l={z}&tk=54953e97a4da8946046f259e11331c4a",
                        //"http://t{s}.tianditu.com/DataServer?T=vec_w&tk=54953e97a4da8946046f259e11331c4a&x={x}&y={y}&l={z}",
                        new[] { "0", "1", "2", "3", "4", "5", "6", "7" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.TDTArial)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "http://t{s}.tianditu.gov.cn/img_w/wmts?SERVICE=WMTS&REQUEST=GetTile&VERSION=1.0.0&LAYER=img&STYLE=default&TILEMATRIXSET=w&FORMAT=tiles&TILEMATRIX={z}&TILEROW={y}&TILECOL={x}&tk=54953e97a4da8946046f259e11331c4a",
                        //"http://t{s}.tianditu.cn/img_w/wmts?service=wmts&tk=54953e97a4da8946046f259e11331c4a&request=GetTile&version=1.0.0&LAYER=img&tileMatrixSet=w&TileMatrix={z}&TileRow={y}&TileCol={x}",
                        new[] { "0", "1", "2", "3", "4", "5", "6", "7" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.TDTLabel)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "https://t{s}.tianditu.gov.cn/DataServer?T=cva_w&tk=54953e97a4da8946046f259e11331c4a&x={x}&y={y}&l={z}",
                        //"http://t{s}.tianditu.com/DataServer?T=cva_w&tk=54953e97a4da8946046f259e11331c4a&x={x}&y={y}&l={z}",
                        new[] { "0","1", "2", "3", "4", "5", "6", "7" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.OSMRoad)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png",
                        new[] { "a", "b", "c" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.OSMBike)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "http://{s}.tile.thunderforest.com/transport/{z}/{x}/{y}.png",
                        new[] { "a", "b", "c" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.OsmTraffic)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "http://{s}.tile.thunderforest.com/cycle/{z}/{x}/{y}.png",
                        new[] { "a", "b", "c" }, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.GoogleHybrid)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 20),
                        "http://khm{s}.googleapis.com/kh?v=190&hl=zh-CN&x={x}&y={y}&z={z}",
                        new[] { "0","1", "2", "3"}, name: _mapType.ToString());
            }
            else if (_mapType == EnumBruTileLayer.GoogleMap)
            {
                return new HttpTileSource(new GlobalSphericalMercator(0, 21),
                        "http://maps.googleapis.com/maps/vt?hl=zh-CN&x={x}&y={y}&z={z}",
                        new[] { "1", "2", "3" }, name: _mapType.ToString());
            }
            return new OsmTileSource();
        }
    }
}
