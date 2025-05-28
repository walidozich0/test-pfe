﻿#nullable disable

using BD;

namespace BD.PublicPortal.Core.DTOs
{

    public partial class BloodTansfusionCenterDTO
    {
        #region Constructors

        public BloodTansfusionCenterDTO() {
        }

        public BloodTansfusionCenterDTO(System.Guid id, string name, string address, string contact, string email, string tel, int wilayaId, List<DonorBloodTransferCenterSubscriptionsDTO> donorBloodTransferCenterSubscriptions, List<BloodDonationRequestDTO> bloodDonationRequests, WilayaDTO wilaya) {

          this.Id = id;
          this.Name = name;
          this.Address = address;
          this.Contact = contact;
          this.Email = email;
          this.Tel = tel;
          this.WilayaId = wilayaId;
          this.DonorBloodTransferCenterSubscriptions = donorBloodTransferCenterSubscriptions;
          this.BloodDonationRequests = bloodDonationRequests;
          this.Wilaya = wilaya;
        }

        #endregion

        #region Properties

        public System.Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }

        public int WilayaId { get; set; }

        #endregion

        #region Navigation Properties

        public List<DonorBloodTransferCenterSubscriptionsDTO> DonorBloodTransferCenterSubscriptions { get; set; }

        public List<BloodDonationRequestDTO> BloodDonationRequests { get; set; }

        public WilayaDTO Wilaya { get; set; }

        #endregion
    }

}
