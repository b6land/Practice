public class RestCountriesStub: RestCountries
{
    public string? ResponseBody;
    public override async Task<string> GetResponseBody(){
        if(string.IsNullOrEmpty(ResponseBody) == false){
            return ResponseBody;
        }

        return await base.GetResponseBody();
    }
}