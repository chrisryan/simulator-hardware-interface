using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Simulator_Interface
{
    internal class ConfigManager
    {
        private const string ConfigFileName = "config.json";

        public static void SaveSettings(ConfigSettings settings)
        {
            // Add JsonSerializerOptions for readable, indented output
            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(settings, options);
            File.WriteAllText(ConfigFileName, jsonString);
        }

        public static ConfigSettings LoadSettings()
        {
            if (!File.Exists(ConfigFileName))
            {
                // Return a new object with default values if the file doesn't exist
                return new ConfigSettings
                {
                    Components = new ConfigComponents
                    {
                        IttLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        IttRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        TorqueLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        TorqueRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        PropRpmLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        PropRpmRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        TurbineRpmLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        TurbineRpmRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        FuelFlowLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        FuelFlowRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        OilTempLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        OilTempRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        OilPressLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        OilPressRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        Airspeed = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        ThrottleLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        ThrottleRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        PitchLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        PitchRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        MixtureLeft = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        MixtureRight = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        RudderTrim = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        },
                        AileronTrim = new ConfigComponentItem
                        {
                            Input = new ConfigRange
                            {
                                From = 0,
                                To = 800
                            },
                            Output = new ConfigRange
                            {
                                From = 0,
                                To = 200
                            }
                        }
                    },
                    Communications = new ConfigCommunications
                    {
                        SerialPort = ""
                    }
                };
            }

            string jsonString = File.ReadAllText(ConfigFileName);
            // Deserialize the JSON string back into an AppSettings object
            return JsonSerializer.Deserialize<ConfigSettings>(jsonString);
        }
    }
}
