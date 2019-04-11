using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsAndDishes.Models
{
    public class NewDishModel
    {
       
        [Required(ErrorMessage = "Dish Name is required")]
        // [MinLength(4)]
        [Display(Name = "Name of Dish:")]
        public string DishName { get; set; }
        [Display(Name = "Description:")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Calories is required")]
        [Display(Name = "Calories:")]
        [Range(1, int.MaxValue,ErrorMessage = "Calories must be greater then 0")]
        public int Calories { get; set; }
        [Required(ErrorMessage = "Tastiness is required")]
        [Display(Name = "Tastiness:")]
        [Range(1, 5)]
        public int Tastiness { get; set; }
        // The MySQL DATETIME type can be represented by a DateTime
        public int ChefId { get; set; }
        // Navigation property for related User object
        public List<Chef> allchefs;
    }


}

