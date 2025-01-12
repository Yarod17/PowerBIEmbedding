﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.PowerBI.Api.Models;
using UserOwnsData.Services;

namespace UserOwnsData.Pages {

  public class EmbedModel : PageModel {
  
    public PowerBiServiceApi PowerBiApi;    
    public string jsonViewModel;

    public EmbedModel(PowerBiServiceApi powerBiApi) {
      this.PowerBiApi = powerBiApi;
    }

    public async Task OnGet(string workspaceId) {

      this.jsonViewModel = await this.PowerBiApi.GetEmbeddedViewModel(workspaceId);
    }

  }
}