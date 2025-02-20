using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidPPTX.Components.Services
{
 
        public class MediaService
        {
            public string ImageUrl { get; private set; } = "imagem_predefenida.png";
            public string VideoUrl { get; private set; } = "Auditoria.mp4";

            public event Action OnChange;

            public void SetMedia(string imageUrl, string videoUrl)
            {
                ImageUrl = imageUrl;
                VideoUrl = videoUrl;
                NotifyStateChanged();
            }

            private void NotifyStateChanged() => OnChange?.Invoke();
        }
    
}
