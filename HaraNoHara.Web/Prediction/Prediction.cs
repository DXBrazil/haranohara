using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Cognitive.CustomVision;
using System.Net.Http;
using System.IO;
using HaraNoHara.Web.Models;
using HaraNoHara.Web.Controllers;

namespace HaraNoHara.Web.Prediction
{
    public class Prediction
    {

       public static void MakePrediction()
        {

            var predictionKey = "031439b0f9ec4549995e53e32971c605";


            PredictionEndpointCredentials predictionEndpointCredentials = new PredictionEndpointCredentials(predictionKey);

            PredictionEndpoint endpoint = new PredictionEndpoint(predictionEndpointCredentials);




            // Make a prediction against the new project

            Console.WriteLine("Making a prediction:");

            var testImage = HomeController.HaraFinalImage;
                


            var projectId = new Guid("62ccee84-08f9-44e7-89f4-6b5b76894a8a");

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