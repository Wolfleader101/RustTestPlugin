
namespace Oxide.Plugins {

    [Info("Test Rust Plugin", "Wolfleader101", "[0.0.1]")]
    [Description("My First ever rust plugin")]
    public class HelloCMD : RustPlugin {

        [ChatCommand("hi")]
        void HelloCmd(BasePlayer player) {
            sendMessage(player, "Hello, " + player.displayName);

        }
        void sendMessage(BasePlayer player, string msg, params object[] args) {
            PrintToChat(player, msg, args);
        }

        void Broadcast(string msg, params object[] args) {
            PrintToChat(msg, args);
        }

        void Loaded() {

            PrintToChat("The plugin has been loaded");

        }
    }
}
