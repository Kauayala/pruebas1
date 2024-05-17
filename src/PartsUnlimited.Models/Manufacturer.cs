// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    // se filtra la informacion de los cambios 17 de mayo
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}