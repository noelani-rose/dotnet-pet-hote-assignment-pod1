using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType 
    {
        Shepherd, 
        Poodle, 
        Beagle, 
        Bulldog, 
        Terrier, 
        Boxer, 
        Labrador, 
        Retriever
    }
    public enum PetColorType 
    {
        Black,
        White,
        Golden,
        Tricolor, 
        Spotted
    }
    public class Pet 
    {
        public int id {get; set;}

        [Required]
        public string name {get; set;}

        [Required]
        public string 

    }
}
