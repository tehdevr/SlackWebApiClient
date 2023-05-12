using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackWebApiClient
{
    public static class SlackUtils
    {
        public static Dictionary<string, List<string>> ExtractInputs(JObject modalViewObj)
        {
            var view = modalViewObj["view"];
            var state = view["state"];
            var valuesObj = state["values"] as JObject;

            Dictionary<string, List<string>> inputs = new Dictionary<string, List<string>>();

            string metadata = view["private_metadata"].Value<string>();
            inputs.Add("metadata", new List<string>() { metadata });

            foreach (var block in valuesObj)
            {
                string blockID = block.Key;
                JObject actionObj = block.Value as JObject;

                foreach (var action in actionObj)
                {
                    string actionID = action.Key;
                    JObject actionValueObj = action.Value as JObject;

                    var actionType = actionValueObj["type"].Value<string>();

                    List<string> values = new List<string>();
                    string valueKey = null;
                    bool isPlainValue = false;
                    bool isMultiPlainValue = false;
                    bool isSingleOption = false;
                    bool isMultiOption = false;

                    switch (actionType)
                    {
                        case "plain_text_input":
                            valueKey = "value";
                            isPlainValue = true;
                            break;

                        case "static_select":
                        case "external_select":
                        case "radio_buttons":
                            valueKey = "selected_option";
                            isSingleOption = true;
                            break;

                        case "users_select":
                            valueKey = "selected_user";
                            isPlainValue = true;
                            break;

                        case "conversations_select":
                            valueKey = "selected_conversation";
                            isPlainValue = true;
                            break;

                        case "channels_select":
                            valueKey = "selected_channel";
                            isPlainValue = true;
                            break;

                        case "datepicker":
                            valueKey = "selected_date";
                            isPlainValue = true;
                            break;

                        case "timepicker":
                            valueKey = "selected_time";
                            isPlainValue = true;
                            break;


                        case "checkboxes":
                        case "multi_static_select":
                        case "multi_external_select":
                            isMultiOption = true;
                            valueKey = "selected_options";
                            break;

                        case "multi_users_select":
                            isMultiPlainValue = true;
                            valueKey = "selected_users";
                            break;

                        case "multi_conversations_select":
                            isMultiPlainValue = true;
                            valueKey = "selected_conversations";
                            break;

                        case "multi_channels_select":
                            isMultiPlainValue = true;
                            valueKey = "selected_channels";
                            break;

                        default:
                            break;
                    }


                    if (valueKey != null)
                    {
                        if (isPlainValue)
                        {
                            values.Add(actionValueObj[valueKey].Value<string>());
                        }
                        else if (isMultiPlainValue)
                        {
                            var ary = actionValueObj[valueKey];
                            values.AddRange(ary.Values<string>());
                        }
                        else if (isSingleOption)
                        {
                            JObject selectedOption = (JObject)actionValueObj[valueKey];
                            values.Add(selectedOption["value"].Value<string>());
                        }
                        else if (isMultiOption)
                        {
                            JToken selectedOptions = actionValueObj[valueKey];
                            if (selectedOptions != null)
                            {
                                foreach (JToken option in selectedOptions)
                                {
                                    values.Add(option["value"].Value<string>());
                                }
                            }
                        }
                        else
                        {
                            // something went wrong, shouldn't be here
                        }

                    }

                    inputs.Add(actionID, values);
                }
            }

            return inputs;
        }
    }
}
