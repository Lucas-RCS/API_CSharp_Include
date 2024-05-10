﻿using API_C_Sharp.LSharp.HTTP;
using API_C_Sharp.Model;
using API_C_Sharp.Model.Post;
using API_C_Sharp.Model.User;
using API_C_Sharp.Utils;
using Newtonsoft.Json.Linq;

namespace API_C_Sharp.Controller
{
    public class PostController
    {

        public static Response create(Request request, Data data)
        {
            string title = (string)request.body.GetValue("title");
            string body = (string)request.body.GetValue("body");
            DateTime date = DateTime.Now;
            DateTime updateDate = DateTime.Now;
            int likes = 0;


            return ResponseUtils.JsonSuccessResponse(JObject.Parse("[]"));
        }

        public static Response list(Request request, Data data)
        {
            Console.WriteLine(data.getPosts());

            JArray postList = new();
            foreach (Post post in data.getPosts())
                postList.Add(post.serialize());

            if (postList.Count == 0)
                return ResponseUtils.JsonSuccessResponse(JObject.Parse("[]"));


            return ResponseUtils.JsonSuccessResponse(postList);
        }

        public static Response getPostById()
        {
            return ResponseUtils.JsonSuccessResponse(JObject.Parse("[]"));
        }

        public static Response getPostLike()
        {
            return ResponseUtils.JsonSuccessResponse(JObject.Parse("[]"));
        }

        public static Response getPostComment()
        {
            return ResponseUtils.JsonSuccessResponse(JObject.Parse("[]"));
        }
    }
}