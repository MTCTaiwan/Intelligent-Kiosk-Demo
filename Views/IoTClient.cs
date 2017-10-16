// 
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
// 
// Microsoft Cognitive Services: http://www.microsoft.com/cognitive
// 
// Microsoft Cognitive Services Github:
// https://github.com/Microsoft/Cognitive
// 
// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 

using System;
using System.Threading.Tasks;
using ServiceHelpers;
using System.Collections.Generic;
using System.Diagnostics;

namespace IntelligentKioskSample.Controls
{
    class IoTClient
    {
        public async static Task Start(Dictionary<String, String> item, string ioTHubConnectString)
        {
            try
            {
                // DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(DeviceConnectionString, Microsoft.Azure.Devices.Client.TransportType.Http1);

                System.Diagnostics.Debug.WriteLine("enter iot");
                System.Diagnostics.Debug.WriteLine(ioTHubConnectString);
                foreach (KeyValuePair<string, string> entry in item)
                {
                    Debug.WriteLine(entry.Key + ":  " + entry.Value);
                }

                //Random rand = new Random();
                //DeviceClient serviceClient = DeviceClient.CreateFromConnectionString(DeviceConnectionString, Microsoft.Azure.Devices.Client.TransportType.Http1);
                //// var serviceClient = Microsoft.Azure.Devices.ServiceClient.CreateFromConnectionString(connectionString, TransportType.Amqp);
                //var str = "Hello";
                //var dict = new Dictionary<string, string>();
                //dict.Add("id", item.Face.FaceId.ToString());
                //dict.Add("gender", item.Face.FaceAttributes.Gender);
                //dict.Add("age", item.Face.FaceAttributes.Age.ToString());
                //dict.Add("date", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                //dict.Add("smile", item.Face.FaceAttributes.Smile.ToString());
                //dict.Add("glasses", item.Face.FaceAttributes.Glasses.ToString());
                //dict.Add("avgs", rand.Next(5, 8).ToString());
                //dict.Add("avgrank", (3 + rand.NextDouble() * 1.5).ToString());
                //dict.Add("unique", item.Unique);
                //dict.Add("anger", item.Anger);
                //dict.Add("contempt", item.Contempt);
                //dict.Add("disgust", item.Disgust);
                //dict.Add("fear", item.Fear);
                //dict.Add("happiness", item.Happiness);
                //dict.Add("neutral", item.Neutral);
                //dict.Add("sadness", item.Sadness);
                //dict.Add("surprise", item.Surprise);
                //var message = new Microsoft.Azure.Devices.Message(System.Text.Encoding.ASCII.GetBytes(str));
                //string json = JsonConvert.SerializeObject(dict, Formatting.Indented);
                //await serviceClient.SendEventAsync(new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(json)));

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error in sample: " + ex.Message);
            }
        }
    }
}