﻿// Copyright (c) DotSpatial Team. All rights reserved.
// Licensed under the MIT license. See License.txt file in the project root for full license information.

using System.IO;
using DotSpatial.Data;
using DotSpatial.Tests.Common;
using NUnit.Framework;

namespace DotSpatial.Analysis.Tests
{
    /// <summary>
    /// This is a test class for ClipWithPolygonTest and is intended to contain all ClipWithPolygonTest Unit Tests.
    /// </summary>
    [TestFixture]
    public class ClipWithPolygonTest
    {
        /// <summary>
        /// A test for ClipRasterWithPolygon.
        /// </summary>
        [Test]
        public void ClipRasterWithPolygonTest()
        {
            var folder = Common.AbsolutePath("Data");

            var shapeFilePath = Path.Combine(folder, "elbe_watershed1.shp");
            var rasterFilePath = Path.Combine(folder, "kriging.bgd");
            var resultFilePath = Path.Combine(folder, "clipResult.bgd");

            var lClipPolygon = Shapefile.OpenFile(shapeFilePath);
            var lGridToClip = Raster.OpenFile(rasterFilePath, false);

            var lGridAfterClip = new Raster { Filename = resultFilePath };
            ClipRaster.ClipRasterWithPolygon(lClipPolygon.Features[0], lGridToClip, lGridAfterClip.Filename);
            var ras2 = Raster.Open(lGridAfterClip.Filename);
            Assert.AreEqual(lGridToClip.NoDataValue, ras2.NoDataValue);
        }
    }
}
