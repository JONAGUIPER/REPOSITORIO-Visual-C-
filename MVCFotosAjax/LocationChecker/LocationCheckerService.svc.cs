using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LocationChecker.GeocodeService;

namespace LocationCheckerWebRole
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class LocationCheckerService : ILocationCheckerService
    {
       
        public string GetLocation(string address)
        {
            string results = string.Empty;
            string key = "AsPcip7ChAzloBDBmSBoyyrjUgPL4PPigzM8-1rCIWLS5H5WGUJZyXZ971zqXACO";
            try
            {
                //Create the geocode request, set the access key and the address to query
                GeocodeRequest geocodeRequest = new GeocodeRequest();
                geocodeRequest.Credentials = new LocationChecker.GeocodeService.Credentials();
                geocodeRequest.Credentials.ApplicationId = key;
                geocodeRequest.Query = address;

                //Create a filter to return only high confidence results
                ConfidenceFilter[] filters = new ConfidenceFilter[1];
                filters[0] = new ConfidenceFilter();
                filters[0].MinimumConfidence = Confidence.High;

                //Apply the filter to the request
                GeocodeOptions options = new GeocodeOptions();
                //options.Filters = filters;
                geocodeRequest.Options = options;

                //Make the request
                GeocodeServiceClient client = new GeocodeServiceClient("BasicHttpBinding_IGeocodeService");
                GeocodeResponse response = client.Geocode(geocodeRequest);

                if (response.Results.Length > 0)
                {
                    results = String.Format("Success: Latitud:{0} Longitud:{1} Altitud:{2}",
                        response.Results[0].Locations[0].Latitude,
                        response.Results[0].Locations[0].Longitude,
                        response.Results[0].Locations[0].Altitude);
                }
                else
                {
                    results = "No Results Found";
                }
            }
            catch (Exception e)
            {
                results = "Geocoding Error: " + e.Message;
            }
            return results;
        }
    }
}
