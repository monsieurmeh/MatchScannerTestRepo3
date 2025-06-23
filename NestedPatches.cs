using HarmonyLib;
using System;

namespace TestMod.NestedPatches
{
    [HarmonyPatch(typeof(Core.Engine.Renderer.Graphics.TextureManager.Advanced.TextureLoader))]
    public class TextureLoaderPatch
    {
        static void Prefix()
        {
            Console.WriteLine("Loading texture");
        }
    }

    [HarmonyPatch("Network.Client.Connection.Handler", nameof(Network.Client.Connection.Handler.ProcessMessage))]
    public class ProcessMessagePatch
    {
        static void Postfix()
        {
            Console.WriteLine("Message processed");
        }
    }
}
