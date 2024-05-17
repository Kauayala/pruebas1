// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// cambios de arquitect A
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    // nuevo cambio para subirlo al sistema
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}