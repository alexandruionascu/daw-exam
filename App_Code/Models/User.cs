﻿public class User {
    [PrimaryKey]
    public int id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public string type { get; set; }
    public string picture { get; set; }
}