
namespace Oxide.Plugins {

    [Info("Test Rust Plugin", "Wolfleader101", "0.0.1")]
    [Description("My First ever rust plugin")]
    public class HelloCMD : RustPlugin {

        [ChatCommand("hi")]
        void HelloCmd(BasePlayer player) {
            sendMessage(player, "Hello, " + player.displayName);
            Puts("Hello Command was fired by: " +player.displayName);

        }
        void sendMessage(BasePlayer player, string msg, params object[] args) {
            PrintToChat(player, msg, args);
        }

        // Use this to send msg to all players on server
        void Broadcast(string msg, params object[] args) {
            PrintToChat(msg, args);
        }

        void Loaded() {
            PrintToChat("Hello Command Plugin has been Loaded");

        }
    }
}
