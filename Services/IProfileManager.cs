
using AriaBlazor.Models;

namespace AriaBlazor.Services;
public interface IProfileManager
{
    IObservable<AriaProfile> ActiveProfileObservable {get;set;}

    AriaProfile[] GetProfiles();

    Task SaveProfilesAsync();
    Task LoadProfilesAsync();

}
