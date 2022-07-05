using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class MessageConstants {
        //
        // GENERIC EVENTS
        //


        // args: 1 (string: error message)
        public const string EVENT_ERROR = "error";

        // error messages
        public const string ERROR_INVALID_DATA = "invalid_data";

        // args: 0 - serverside event, called when a client disconnects
        public const string EVENT_DISCONNECT = "disconnect";


        //
        // PLAYER EVENTS
        //


        // args: 1 (string: new name, max 16 chars)
        public const string EVENT_PLAYER_SET_NAME_REQUEST = "player_set_name_request";

        // args: 1 (string: new name or player error)
        public const string EVENT_PLAYER_SET_NAME_RESPONSE = "player_set_name_response";

        // player errors
        public const string ERROR_PLAYER_NAME_TAKEN = "player_name_taken";



        //
        // ROOM EVENTS
        //


        // args: 1 (bool: is this quickplay?)
        public const string EVENT_ROOM_CREATE_REQUEST = "room_create_request";

        // args: 1 (string: room id to join)
        public const string EVENT_ROOM_JOIN_REQUEST = "room_join_request";
        // args: 1 (string: room id joined or room error)
        public const string EVENT_ROOM_JOIN_RESPONSE = "room_join_response";
        // args: 1 (string: name of player who joined the room)
        public const string EVENT_PLAYER_ROOM_JOIN_BROADCAST = "player_room_join_broadcast";
        
        /// <summary>
        /// args: 0
        /// </summary>
        public const string EVENT_ROOM_LEAVE_REQUEST = "room_leave_request";
        // args: 1 (bool: leave success?)
        public const string EVENT_ROOM_LEAVE_RESPONSE = "room_leave_response";
        /// <summary>
        /// args: 1 (string: name of player who left the room)
        /// </summary>
        public const string EVENT_PLAYER_ROOM_LEAVE_BROADCAST = "player_room_leave_broadcast";

        // room errors
        public const string ERROR_ROOM_ID_GENERATION_FAILED = "room_id_generation_failed";
        public const string ERROR_ROOM_INVALID_ID = "room_invalid_id";
        public const string ERROR_ROOM_FULL = "room_full";
    }
}
