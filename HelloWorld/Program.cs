﻿using HelloWorld.Business.Models;
using System.Text.Json;

List<Movie> movies = new();

using (HttpClient client = new())
{
    HttpResponseMessage response = await client.GetAsync("https://localhost:7133/api/movies");

    if (response.IsSuccessStatusCode)
    {
        string content = await response.Content.ReadAsStringAsync();
        movies = JsonSerializer.Deserialize<List<Movie>>(content);
    }
    else
        Console.WriteLine("Error while getting the information from the API.");
}

    foreach (Movie movie in movies)
    {
        Console.WriteLine(movie.Title);
        Console.WriteLine(movie.ReleaseDate.ToString());
        Console.WriteLine("");
        Console.WriteLine(movie.Plot);
        Console.WriteLine("----------------------");
    }
