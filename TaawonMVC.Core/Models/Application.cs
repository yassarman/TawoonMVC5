using Abp.Authorization.Users;
using TaawonMVC.Valedation;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
   public class Application :FullAuditedEntity
    {
        public Application()
        {
            CreationTime = Clock.Now;
            Name = "";
            idNumber = 0;
            propertytId = 0;
            houseHoldNumber = 0;
            phoneNumber = "";
            specialNeeds = 0;
            specialNeedType = "";
            alternativeResidence = 0;
            previousRestortion = "";
            previousRestortionDate = DateTime.MinValue;
            previousRestortionAmount = "";
            previousRestortionSource = "";
            previousRestortionType = "";
            interrestedRepairingEntity = 0;
            interrestedRepairingEntityName = "";
            housingSince = DateTime.MinValue;
            legalDispute = 0;
            ownerAgreementEnsured = 0;
            appliedForMunicipality = 0;
            restortionType = 0;
            residentStatus = 0;
            ownership = 0;
            propertyType = 0;
            //photo = Image.FromFile("");
            ApplicationRecivedDate = DateTime.MinValue;
            Status = 0;
            BuildingUnitID = 0;
        }

         [Required]
         [Display(Name ="Name")]
         [MaxLength(AbpUserBase.MaxNameLength)]
          public string Name { get; set; }

        [Required(AllowEmptyStrings =true,ErrorMessage ="You should enter IdNumber")]
       // [MaxLength(30,ErrorMessage ="Id Number is less than 30")]
        public int idNumber { get; set; }
        //[key]
        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter propertytId")]
       // [MaxLength(30, ErrorMessage = "propertytId is less than 30")]
        public int propertytId { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter houseHoldNumber")]
       // [MaxLength(30, ErrorMessage = "houseHoldNumber is less than 30")]
        public int houseHoldNumber { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter phoneNumber")]
        [MaxLength(30, ErrorMessage = "phoneNumber is less than 30")]
        public string phoneNumber { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter specialNeeds")]
       // [MaxLength(30, ErrorMessage = "specialNeeds is less than 30")]
        public byte specialNeeds { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter specialNeedType")]
        [MaxLength(30, ErrorMessage = "specialNeedType is less than 30")]
        public string specialNeedType { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter alternativeResidence")]
        //[MaxLength(30, ErrorMessage = "alternativeResidence is less than 30")]
        public byte alternativeResidence { get; set; }

        [Required(AllowEmptyStrings =true, ErrorMessage = "You should enter previousRestortion")]
        [MaxLength(30, ErrorMessage = "previousRestortion is less than 30")]
        public string previousRestortion { get; set; }

        [Required(AllowEmptyStrings =true, ErrorMessage = "You should enter previousRestortionDate")]
        // vlaidate date method 
        public DateTime previousRestortionDate { get; set; }

        [MaxLength(30, ErrorMessage = "specialNeedType is less than 30")]
        public string previousRestortionAmount { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter previousRestortionSource")]
        [MaxLength(30, ErrorMessage = "previousRestortionSource is less than 30")]
        public string previousRestortionSource { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter previousRestortionType")]
        [MaxLength(30, ErrorMessage = "previousRestortionType is less than 30")]
        public string previousRestortionType { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter interrestedRepairingEntity")]
        //[MaxLength(30, ErrorMessage = "interrestedRepairingEntity is less than 30")]
        public byte interrestedRepairingEntity { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter interrestedRepairingEntityName")]
        [MaxLength(30, ErrorMessage = "interrestedRepairingEntityName is less than 30")]
        public string interrestedRepairingEntityName { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter housingSince")]
        public DateTime housingSince { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter legalDispute")]
        //[MaxLength(30, ErrorMessage = "legalDispute is less than 30")]
        public byte legalDispute { get; set; }

        [Required(AllowEmptyStrings =true, ErrorMessage = "You should enter ownerAgreementEnsured")]
        //[MaxLength(30, ErrorMessage = "ownerAgreementEnsured is less than 30")]
        public byte ownerAgreementEnsured { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter appliedForMunicipality")]
        //[MaxLength(30, ErrorMessage = "appliedForMunicipality is less than 30")]
        public byte appliedForMunicipality { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter restortionType")]
       // [MaxLength(30, ErrorMessage = "restortionType is less than 30")]
        public int restortionType { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter residentStatus")]
        //[MaxLength(30, ErrorMessage = "residentStatus is less than 30")]
        public int residentStatus { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter ownership")]
        //[MaxLength(30, ErrorMessage = "ownership is less than 30")]
        public int ownership { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter propertyType")]
        //[MaxLength(30, ErrorMessage = "propertyType is less than 30")]
        public int propertyType { get; set; }

        
        
       // public Image photo { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter DateTime")]
        //validate date method 
        public DateTime ApplicationRecivedDate { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter Status")]
        //[MaxLength(30, ErrorMessage = "Status is less than 30")]
        public int Status { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "You should enter BuildingUnitID")]
        //[MaxLength(30, ErrorMessage = "BuildingUnitID is less than 30")]
        public int BuildingUnitID { get; set; }
        
    }
}
