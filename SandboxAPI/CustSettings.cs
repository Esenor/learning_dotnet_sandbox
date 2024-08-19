using System.ComponentModel.DataAnnotations;

namespace SandboxAPI
{
    public class CustSettings
    {
        [Required]
        public required string AppName { get; set; }
        public int Version { get; set; }
    }
}
