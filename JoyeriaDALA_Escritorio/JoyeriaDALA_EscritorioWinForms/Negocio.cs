using JoyeriaDALA_EscritorioWinForms.Modelo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JoyeriaDALA_EscritorioWinForms
{
        public class Negocio
        {
            private readonly HttpClient _httpClient;
            private readonly string url = GlobalValues.api_url;

            public Negocio()
            {

                _httpClient = new HttpClient();
                _httpClient.Timeout = TimeSpan.FromSeconds(160);
                
        }

            public async Task<T> GetAsync<T>(string breakpoint)
            {
            try
            {
                var response = await _httpClient.GetAsync($"{url}/{breakpoint}");

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    T objeto = JsonConvert.DeserializeObject<T>(data);
                    return objeto;
                }
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return default(T);
                }

                //throw new Exception("Error en la conexión. Codigo "+response.StatusCode);
            }catch(Exception ex)
            {
                MessageBox.Show("Error de conexion: " + ex.ToString());
               // throw new Exception("Error en la conexión: " +ex.Message);
            }
            return default;
            }

      

            public async Task<T> PostAsync<T>(string endpoint, T objeto, string apikey)
            {
                var json = JsonConvert.SerializeObject(objeto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
               // content.Headers.Add("key", apikey);

                var response = await _httpClient.PostAsync($"{url}/{endpoint}", content);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    T result = JsonConvert.DeserializeObject<T>(data);
                    return result;
                }

                return default;
            }

            public async Task<T> PutAsync<T>(string endpoint, T objeto, int id, string apikey)
            {
                endpoint = string.Format(endpoint, id);
                var json = JsonConvert.SerializeObject(objeto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                content.Headers.Add("key", apikey);

                var response = await _httpClient.PutAsync($"{url}/{endpoint}", content);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    T result = JsonConvert.DeserializeObject<T>(data);
                    return result;
                }

                return default;
            }

            public async Task<bool> DeleteAsync(string breakpoint, string apikey)
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, $"{url}/{breakpoint}");
                request.Headers.Add("key", apikey);

                var response = await _httpClient.SendAsync(request);
                return response.IsSuccessStatusCode;
            }

            public async Task<T> PostJsonObjectAsync<T>(string endpoint, JObject jsonObject, string apikey)
            {
                var json = jsonObject.ToString();
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                content.Headers.Add("key", apikey);

                var response = await _httpClient.PostAsync($"{url}/{endpoint}", content);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    T result = JsonConvert.DeserializeObject<T>(data);
                    return result;
                }

                return default;
            }

        public async Task<T> PutJsonObjectAsync<T>(string endpoint, JObject jsonObject, int id, string apikey)
        {
            var json = jsonObject.ToString();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.Add("key", apikey);

            var response = await _httpClient.PutAsync($"{url}/{string.Format(endpoint, id)}", content);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                T result = JsonConvert.DeserializeObject<T>(data);
                return result;
            }

            return default;
        }

        public async Task<bool> LoginAsync(string usuario, string contra)
        {
            // Encriptar la contraseña usando AES
            string encryptedPassword = EncryptString(contra);

            // Enviar las credenciales encriptadas a la API
            StringContent content = new StringContent("");
            Usuario user = new Usuario
            {
                username = usuario,
                password = encryptedPassword
            };
            try
            {
                // Llamar al método de Login en la API
               if(await PostAsync<Usuario>("Usuario/Login", user, "apikey") != null)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir
                MessageBox.Show("Error de conexión: " + ex.ToString());
                return false;
            }
        }


            // Método para encriptar la contraseña usando AES
            private string EncryptString(string plainText)
            {
                byte[] encryptedData;
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(GlobalValues.encriptionKey);
                    aesAlg.IV = new byte[aesAlg.BlockSize / 8]; // Initialization Vector (IV) estático en este ejemplo

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    encryptedData = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                }

                return Convert.ToBase64String(encryptedData);
            }

        /*  public async Task<T> LoginAsync<T>(string usuario, string contra)
        {
            StringContent content = new StringContent("");
            content.Headers.Add("user", usuario);
            content.Headers.Add("pswd", contra);
            var response = await _httpClient.PostAsync($"{url}/loginAdmin", content);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                T objeto = JsonConvert.DeserializeObject<T>(data);
                return objeto;
            }
            return default;
        }*/
    }
}
