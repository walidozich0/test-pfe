﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Data Transfer Object template.
// Code is generated on: 21-05-2025 19:14:54
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace BD.BloodCentral.Core
{

    public static partial class CommuneConverter
    {

        public static CommuneDTO ToDto(this Commune source)
        {
            return source.ToDtoWithRelated(0);
        }

        public static CommuneDTO ToDtoWithRelated(this Commune source, int level)
        {
            if (source == null)
              return null;

            var target = new CommuneDTO();

            // Properties
            target.Id = source.Id;
            target.Name = source.Name;
            target.WilayaId = source.WilayaId;

            // Navigation Properties
            if (level > 0) {
              target.Wilaya = source.Wilaya.ToDtoWithRelated(level - 1);
              target.Donors = source.Donors.ToDtosWithRelated(level - 1);
            }

            // User-defined partial method
            OnDtoCreating(source, target);

            return target;
        }

        public static Commune ToEntity(this CommuneDTO source)
        {
            if (source == null)
              return null;

            var target = new Commune();

            // Properties
            target.Id = source.Id;
            target.Name = source.Name;
            target.WilayaId = source.WilayaId;

            // User-defined partial method
            OnEntityCreating(source, target);

            return target;
        }

        public static List<CommuneDTO> ToDtos(this IEnumerable<Commune> source)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToDto())
              .ToList();

            return target;
        }

        public static List<CommuneDTO> ToDtosWithRelated(this IEnumerable<Commune> source, int level)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToDtoWithRelated(level))
              .ToList();

            return target;
        }

        public static List<Commune> ToEntities(this IEnumerable<CommuneDTO> source)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToEntity())
              .ToList();

            return target;
        }

        static partial void OnDtoCreating(Commune source, CommuneDTO target);

        static partial void OnEntityCreating(CommuneDTO source, Commune target);

    }

}
