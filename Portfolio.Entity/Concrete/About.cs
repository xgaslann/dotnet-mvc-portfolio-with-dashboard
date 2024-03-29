﻿using System.ComponentModel.DataAnnotations;

namespace Portfolio.Entity.Concrete;

public class About
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string ImageUrl { get; set; }

}