using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    /// <summary>
    /// This class contains possible messages that can be send via SocketIO.<p>
    /// If the field name ends with REQUEST, then the client emits messages to this event and the server listens to it.<p>
    /// If it ends with RESPONSE, then the client listens and the server emits. <p>
    /// If it ends with BROADCAST, it was sent from the server to all players in a room.
    /// </summary>
    public class MessageConstants
    {
        ///
        /// GENERIC EVENTS
        ///



        /// Event for sending errors to the client.<p>
        /// Arguments (1):<p>
        /// - string: error message (Anything starting with ERROR)
        public const string EVENT_ERROR_RESPONSE = "error";

        /// Only Serverside (no client emit): Called from SocketIO, when a client disconnects.<p>
        /// Arguments: 0
        public const string SERVERSIDE_EVENT_DISCONNECT = "disconnect";

        /// Error message if the player sent invalid data.
        /// @see MessageConstants#EVENT_ERROR_REPSONSE
        public const string ERROR_INVALID_DATA = "error_invalid_data";



        ///
        /// PLAYER EVENTS
        ///




        /// Event for requesting a name change.<p>
        /// Arguments (1):<p>
        /// - string: new name, max 16 chars
        public const string EVENT_PLAYER_SET_NAME_REQUEST = "player_set_name_request";

        /// Response event for a name change request.<p>
        /// Arguments (1):<p>
        /// - string: new name or a (future) error starting with ERROR_PLAYER
        public const string EVENT_PLAYER_SET_NAME_RESPONSE = "player_set_name_response";

        /// Event for requesting to apply e.g. player input on the next tick.
        public const string EVENT_PLAYER_INPUT_REQUEST = "player_input_request";



        ///
        /// ROOM EVENTS
        ///




        /// Event for requesting a room creation.<p>
        /// Arguments (1):<p>
        /// - bool: is this quickplay?
        public const string EVENT_ROOM_CREATE_REQUEST = "room_create_request";

        /// Event for requesting to join an existing room.<p>
        /// Arguments (1):<p>
        /// - string: room id to join
        public const string EVENT_ROOM_JOIN_REQUEST = "room_join_request";

        /// Response event for a room join request.
        /// Arguments (1):<p>
        /// - string: the id of the joined room or an error starting with ERROR_ROOM
        public const string EVENT_ROOM_JOIN_RESPONSE = "room_join_response";

        /// Event broadcasting a player joining a room.
        /// Arguments (1):<p>
        /// - string: name of player who joined the room
        public const string EVENT_ROOM_PLAYER_JOIN_BROADCAST = "room_player_join_broadcast";

        /// Event for requesting to leave a room.
        /// Arguments: 0
        public const string EVENT_ROOM_LEAVE_REQUEST = "room_leave_request";

        /// Response event for a room join request.
        /// Arguments (1):<p>
        /// - bool: leave success?
        public const string EVENT_ROOM_LEAVE_RESPONSE = "room_leave_response";

        /// Event broadcasting a player left a room.
        /// Arguments (1):<p>
        /// - string: name of player who left the room
        public const string EVENT_ROOM_PLAYER_LEAVE_BROADCAST = "room_player_leave_broadcast";

        /// Error message if the room id generation failed.
        /// @see MessageConstants#EVENT_ERROR_REPSONSE
        public const string ERROR_ROOM_ID_GENERATION_FAILED = "error_room_id_generation_failed";

        /// Error message if the room id doesn't exist or is invalid.
        /// @see MessageConstants#EVENT_ERROR_REPSONSE
        public const string ERROR_ROOM_INVALID_ID = "error_room_invalid_id";

        /// Error message if the room is full.
        /// @see MessageConstants#EVENT_ERROR_REPSONSE
        public const string ERROR_ROOM_FULL = "error_room_full";
    }
}
