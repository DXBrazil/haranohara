﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Cognitive.CustomVision;
using System.Net.Http;
using System.IO;
using HaraNoHara.Web.Models;

namespace HaraNoHara.Web.Prediction
{
    public class Prediction
    {

        static void MakePrediction()
        {

            var predictionKey = "insert your prediction key here";


            PredictionEndpointCredentials predictionEndpointCredentials = new PredictionEndpointCredentials(predictionKey);

            PredictionEndpoint endpoint = new PredictionEndpoint(predictionEndpointCredentials);




            // Make a prediction against the new project

            Console.WriteLine("Making a prediction:");

            var testImage = new MemoryStream(File.ReadAllBytes(@"insert the picture you want to compare here"));


            var projectId = new Guid("insert the project guid here");

            var result = endpoint.PredictImage(projectId, testImage, null, null);



            // Loop over each prediction and write out the results

            foreach (var c in result.Predictions)

            {

                Console.WriteLine($"\t{c.Tag}: {c.Probability:P1}");

                PredictionResults pr = new PredictionResults();

                pr.tag = c.Tag;
                pr.prediction = c.Probability;

            }

        }

    }

}