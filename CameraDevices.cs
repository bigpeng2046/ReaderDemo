﻿/*
 * Copyright 2012 ZXing.Net authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

using AForge.Video.DirectShow;

namespace ReaderDemo
{
   internal class CameraDevices
   {
      private FilterInfoCollection deviceColl;
      public FilterInfoCollection Devices { 
          get { return this.deviceColl; }
      }

      private VideoCaptureDevice videoDevice;
      public VideoCaptureDevice Current { 
          get { return this.videoDevice; }
      }

      public CameraDevices()
      {
         this.deviceColl = new FilterInfoCollection(FilterCategory.VideoInputDevice);
      }

      public void SelectCamera(int index)
      {
         if (index >= Devices.Count)
         {
            throw new ArgumentOutOfRangeException("index");
         }
         this.videoDevice = new VideoCaptureDevice(Devices[index].MonikerString);
      }
   }
}
