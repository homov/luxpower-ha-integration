using System;

namespace LxpModbus
{
    /// <summary>
    /// Constants for the LuxPower Inverter (Modbus) integration
    /// Translated from Python const.py
    /// </summary>
    public static class Constants
    {
        public const string DOMAIN = "lxp_modbus";

        // Platform types equivalent to Python's Platform enum
        public static readonly string[] PLATFORMS = new[]
        {
            "sensor",
            "number",
            "time",
            "select",
            "button",
            "switch"
        };

        // Configuration constants
        public const string CONF_HOST = "host";
        public const string CONF_PORT = "port";
        public const string CONF_DONGLE_SERIAL = "dongle_serial";
        public const string CONF_INVERTER_SERIAL = "inverter_serial";
        public const string CONF_POLL_INTERVAL = "poll_interval";
        public const string CONF_ENTITY_PREFIX = "entity_prefix";
        public const string CONF_RATED_POWER = "rated_power";
        public const string CONF_READ_ONLY = "read_only";
        public const string CONF_REGISTER_BLOCK_SIZE = "register_block_size";
        public const string CONF_CONNECTION_RETRIES = "connection_retries";
        public const string CONF_ENABLE_DEVICE_GROUPING = "enable_device_grouping";

        public const string INTEGRATION_TITLE = "LuxPower Inverter (Modbus)";

        // Default values
        public const int DEFAULT_POLL_INTERVAL = 60;  // or whatever default you prefer, in seconds
        public const string DEFAULT_ENTITY_PREFIX = "";
        public const int DEFAULT_RATED_POWER = 5000;
        public const bool DEFAULT_READ_ONLY = false;
        public const int DEFAULT_PORT = 8000;
        public const int DEFAULT_REGISTER_BLOCK_SIZE = 125;
        public const int DEFAULT_CONNECTION_RETRIES = 3;
        public const bool DEFAULT_ENABLE_DEVICE_GROUPING = true;

        // Legacy firmware may only support smaller block sizes
        public const int LEGACY_REGISTER_BLOCK_SIZE = 40;
        public const int TOTAL_REGISTERS = 300;  // Total number of registers available

        // Packet recovery constants
        public const int MAX_PACKET_RECOVERY_ATTEMPTS = 3;
        public const int MAX_PACKET_SIZE = 1024;  // Maximum reasonable packet size in bytes
        public const int PACKET_RECOVERY_TIMEOUT = 2;  // Timeout for packet recovery operations

        public const int RESPONSE_OVERHEAD = 37;  // minimum resposne length received from inverter (technical information)
        public const int WRITE_RESPONSE_LENGTH = 76;  // Based on documentation for a single write ack
    }
}
