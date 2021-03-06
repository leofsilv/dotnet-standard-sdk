/**
* Copyright 2018 IBM Corp. All Rights Reserved.
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
*
*/

using System.Collections.Generic;
using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;

namespace IBM.WatsonDeveloperCloud.VisualRecognition.v3
{
    public partial interface IVisualRecognitionService
    {
        ClassifiedImages Classify(System.IO.FileStream imagesFile = null, string acceptLanguage = null, string url = null, float? threshold = null, List<string> owners = null, List<string> classifierIds = null, string imagesFileContentType = null, Dictionary<string, object> customData = null);
        DetectedFaces DetectFaces(System.IO.FileStream imagesFile = null, string url = null, string imagesFileContentType = null, string acceptLanguage = null, Dictionary<string, object> customData = null);
        BaseModel DeleteClassifier(string classifierId, Dictionary<string, object> customData = null);
        Classifier GetClassifier(string classifierId, Dictionary<string, object> customData = null);
        Classifiers ListClassifiers(bool? verbose = null, Dictionary<string, object> customData = null);
        BaseModel DeleteUserData(string customerId, Dictionary<string, object> customData = null);
    }
}
