// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputMaster : IInputActionCollection
{
    private InputActionAsset asset;
    public InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f1a893e7-d859-4933-a0e9-2a16904800c3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cb24b449-2075-4117-ac1f-c37af59fcb86"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""70c1c497-bf58-4fe8-8e7c-00dab2c6bbd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e0539d00-ce28-4330-9ee5-eea8c38077a4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f916ed9d-daef-467e-89f8-46c956229011"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""arrowKeys"",
                    ""id"": ""e9629507-53d9-40e5-a3ed-ef89f33dc67c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c6f2cb2-5ac7-408a-bc5e-ad41a396292a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0685b0f7-43e6-4057-a74d-7649fb2a7bce"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2d336c28-6db0-4084-ad86-ea70c2106f95"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9565358d-54c1-4930-91b5-d15ccdb102e7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""wasdKeys"",
                    ""id"": ""ae5e552c-fbba-4960-a440-290f3d54cab5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5116131d-62fc-4130-b212-1656ee126c3e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""da5c5cd7-fa6d-4fbe-a42b-4f485b4a752a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""878b6b15-bda4-44a1-bfb1-a19bcb9929eb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""29c50afd-4983-425a-bb4e-5ea6c0f6396b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""2f0e98ea-bc9c-48ca-99f3-be420965506f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0027c4cf-0820-4809-ad53-fd27d20bb689"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""989d16c2-2551-4370-b67b-978462233a96"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73e2ac3f-5fe1-4e1e-b06d-068f0692942b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4f8f467c-6c0a-42b8-90c3-58912fcb0eea"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""331f22a8-67fe-4b89-a922-2e3b7e240bc3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e70b6d7-a4a4-40eb-987a-f1d88b7de9b2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d304d732-b203-42b8-b14f-de75107cd4ae"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6611f41d-e50f-49d0-bbcb-bde9bfb185fa"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddd72297-ee78-4527-b8ae-6b560220cae6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4cd28ac2-9191-4d79-8ab8-94a97cc3980f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""fe02a89e-cf98-4ddc-b6a5-963080a8a6d8"",
            ""actions"": [
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""34ef5eca-51b1-44c2-93c8-c0409c1d206a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Answer Up"",
                    ""type"": ""Button"",
                    ""id"": ""4266881a-0d29-4d82-a861-ca99b7638ac2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Answer Down"",
                    ""type"": ""Button"",
                    ""id"": ""4a03f352-7336-48c1-be64-6890facb9039"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Choose Answer"",
                    ""type"": ""Button"",
                    ""id"": ""567a2958-e643-4610-a162-19d7668c54dd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57326cb8-aa61-43f9-83f2-7baa43b35831"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""099c5ae1-2eaa-4350-ab64-fcf83f074f38"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Answer Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc0d750b-cfda-40b6-8688-16ee72bc596b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Answer Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a76dead0-eed1-44a7-aa77-084ceaf88d27"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Choose Answer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GUI"",
            ""id"": ""53c39981-e7e5-4350-87b9-6302559e306c"",
            ""actions"": [
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""21336c55-e37f-4fcc-b610-d2b026e1a491"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quest Window"",
                    ""type"": ""Button"",
                    ""id"": ""eca61752-04ec-458a-8353-8a988a30e093"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause Menu"",
                    ""type"": ""Button"",
                    ""id"": ""2b40e2fd-0292-40f9-868a-01bf3895d47b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stat Window"",
                    ""type"": ""Button"",
                    ""id"": ""00af2002-1661-46d1-b5b8-abce631d3ffa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""16762524-3da0-4bf9-9af0-f5f7e2963706"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Pause Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0b12210-194b-4c01-82fd-ebdd648a894f"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Quest Window"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74dd5d49-79af-4bac-880a-212db25a48fa"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96b7b193-e6ff-409e-8bb2-454e9bc420b4"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Stat Window"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""d3b8f62a-1039-4898-9e41-a7786ea30c1c"",
            ""actions"": [
                {
                    ""name"": ""Item 1"",
                    ""type"": ""Button"",
                    ""id"": ""f41e5a59-5029-494b-ac20-2f3960118031"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 2"",
                    ""type"": ""Button"",
                    ""id"": ""7b997574-5843-49ce-9a0f-26ccb2c6b5e9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 3"",
                    ""type"": ""Button"",
                    ""id"": ""8f7ecae6-d5cc-460b-b15c-71c3b606bc35"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 4"",
                    ""type"": ""Button"",
                    ""id"": ""194d9da1-7ebd-46f2-9dd3-09065a97a60b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 5"",
                    ""type"": ""Button"",
                    ""id"": ""b949e705-a3f6-4622-a636-33b75a95b5b2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 6"",
                    ""type"": ""Button"",
                    ""id"": ""69efb2c5-37f9-4616-b3da-3042a8ea6ce5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 7"",
                    ""type"": ""Button"",
                    ""id"": ""85fbc1b4-bc7a-48d5-a69a-57e8231222ae"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 8"",
                    ""type"": ""Button"",
                    ""id"": ""c119a3e3-971a-40aa-a779-e39ef74df264"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 9"",
                    ""type"": ""Button"",
                    ""id"": ""256c4af1-1613-4060-b92f-69bfd0bedfc9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item 10"",
                    ""type"": ""Button"",
                    ""id"": ""21dd1e03-7e9a-4ae5-9d47-2f9d11205044"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""016d6538-b846-4a3f-b411-62e637618440"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc45fa8a-342d-41f2-a9d8-b5a7d01e71b1"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2161f3d1-aa17-450a-bd51-0a76fea6450d"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93db16d3-b173-49c0-b60b-928174813b19"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7ad67a3-5c9f-4344-bf65-922abb5f5f9b"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""186a69b2-e725-44ff-a79a-3aa2ebb95039"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35bb71b1-b688-43dc-8f9f-638c83193c3c"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ae30fac-782b-443a-8da7-4de19b456d3c"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b7c6951-e94d-4e29-808a-63ff5f2988a0"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""266545b0-a056-46f3-ad14-92cf9185a28e"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Item 10"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""basedOn"": """",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""basedOn"": """",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.GetActionMap("Player");
        m_Player_Movement = m_Player.GetAction("Movement");
        m_Player_Interact = m_Player.GetAction("Interact");
        m_Player_Attack = m_Player.GetAction("Attack");
        m_Player_Shoot = m_Player.GetAction("Shoot");
        // Dialogue
        m_Dialogue = asset.GetActionMap("Dialogue");
        m_Dialogue_Continue = m_Dialogue.GetAction("Continue");
        m_Dialogue_AnswerUp = m_Dialogue.GetAction("Answer Up");
        m_Dialogue_AnswerDown = m_Dialogue.GetAction("Answer Down");
        m_Dialogue_ChooseAnswer = m_Dialogue.GetAction("Choose Answer");
        // GUI
        m_GUI = asset.GetActionMap("GUI");
        m_GUI_Inventory = m_GUI.GetAction("Inventory");
        m_GUI_QuestWindow = m_GUI.GetAction("Quest Window");
        m_GUI_PauseMenu = m_GUI.GetAction("Pause Menu");
        m_GUI_StatWindow = m_GUI.GetAction("Stat Window");
        // Inventory
        m_Inventory = asset.GetActionMap("Inventory");
        m_Inventory_Item1 = m_Inventory.GetAction("Item 1");
        m_Inventory_Item2 = m_Inventory.GetAction("Item 2");
        m_Inventory_Item3 = m_Inventory.GetAction("Item 3");
        m_Inventory_Item4 = m_Inventory.GetAction("Item 4");
        m_Inventory_Item5 = m_Inventory.GetAction("Item 5");
        m_Inventory_Item6 = m_Inventory.GetAction("Item 6");
        m_Inventory_Item7 = m_Inventory.GetAction("Item 7");
        m_Inventory_Item8 = m_Inventory.GetAction("Item 8");
        m_Inventory_Item9 = m_Inventory.GetAction("Item 9");
        m_Inventory_Item10 = m_Inventory.GetAction("Item 10");
    }

    ~InputMaster()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_Shoot;
    public struct PlayerActions
    {
        private InputMaster m_Wrapper;
        public PlayerActions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Interact.started += instance.OnInteract;
                Interact.performed += instance.OnInteract;
                Interact.canceled += instance.OnInteract;
                Attack.started += instance.OnAttack;
                Attack.performed += instance.OnAttack;
                Attack.canceled += instance.OnAttack;
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private IDialogueActions m_DialogueActionsCallbackInterface;
    private readonly InputAction m_Dialogue_Continue;
    private readonly InputAction m_Dialogue_AnswerUp;
    private readonly InputAction m_Dialogue_AnswerDown;
    private readonly InputAction m_Dialogue_ChooseAnswer;
    public struct DialogueActions
    {
        private InputMaster m_Wrapper;
        public DialogueActions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Continue => m_Wrapper.m_Dialogue_Continue;
        public InputAction @AnswerUp => m_Wrapper.m_Dialogue_AnswerUp;
        public InputAction @AnswerDown => m_Wrapper.m_Dialogue_AnswerDown;
        public InputAction @ChooseAnswer => m_Wrapper.m_Dialogue_ChooseAnswer;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void SetCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterface != null)
            {
                Continue.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnContinue;
                Continue.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnContinue;
                Continue.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnContinue;
                AnswerUp.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnAnswerUp;
                AnswerUp.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnAnswerUp;
                AnswerUp.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnAnswerUp;
                AnswerDown.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnAnswerDown;
                AnswerDown.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnAnswerDown;
                AnswerDown.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnAnswerDown;
                ChooseAnswer.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnChooseAnswer;
                ChooseAnswer.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnChooseAnswer;
                ChooseAnswer.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnChooseAnswer;
            }
            m_Wrapper.m_DialogueActionsCallbackInterface = instance;
            if (instance != null)
            {
                Continue.started += instance.OnContinue;
                Continue.performed += instance.OnContinue;
                Continue.canceled += instance.OnContinue;
                AnswerUp.started += instance.OnAnswerUp;
                AnswerUp.performed += instance.OnAnswerUp;
                AnswerUp.canceled += instance.OnAnswerUp;
                AnswerDown.started += instance.OnAnswerDown;
                AnswerDown.performed += instance.OnAnswerDown;
                AnswerDown.canceled += instance.OnAnswerDown;
                ChooseAnswer.started += instance.OnChooseAnswer;
                ChooseAnswer.performed += instance.OnChooseAnswer;
                ChooseAnswer.canceled += instance.OnChooseAnswer;
            }
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);

    // GUI
    private readonly InputActionMap m_GUI;
    private IGUIActions m_GUIActionsCallbackInterface;
    private readonly InputAction m_GUI_Inventory;
    private readonly InputAction m_GUI_QuestWindow;
    private readonly InputAction m_GUI_PauseMenu;
    private readonly InputAction m_GUI_StatWindow;
    public struct GUIActions
    {
        private InputMaster m_Wrapper;
        public GUIActions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Inventory => m_Wrapper.m_GUI_Inventory;
        public InputAction @QuestWindow => m_Wrapper.m_GUI_QuestWindow;
        public InputAction @PauseMenu => m_Wrapper.m_GUI_PauseMenu;
        public InputAction @StatWindow => m_Wrapper.m_GUI_StatWindow;
        public InputActionMap Get() { return m_Wrapper.m_GUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GUIActions set) { return set.Get(); }
        public void SetCallbacks(IGUIActions instance)
        {
            if (m_Wrapper.m_GUIActionsCallbackInterface != null)
            {
                Inventory.started -= m_Wrapper.m_GUIActionsCallbackInterface.OnInventory;
                Inventory.performed -= m_Wrapper.m_GUIActionsCallbackInterface.OnInventory;
                Inventory.canceled -= m_Wrapper.m_GUIActionsCallbackInterface.OnInventory;
                QuestWindow.started -= m_Wrapper.m_GUIActionsCallbackInterface.OnQuestWindow;
                QuestWindow.performed -= m_Wrapper.m_GUIActionsCallbackInterface.OnQuestWindow;
                QuestWindow.canceled -= m_Wrapper.m_GUIActionsCallbackInterface.OnQuestWindow;
                PauseMenu.started -= m_Wrapper.m_GUIActionsCallbackInterface.OnPauseMenu;
                PauseMenu.performed -= m_Wrapper.m_GUIActionsCallbackInterface.OnPauseMenu;
                PauseMenu.canceled -= m_Wrapper.m_GUIActionsCallbackInterface.OnPauseMenu;
                StatWindow.started -= m_Wrapper.m_GUIActionsCallbackInterface.OnStatWindow;
                StatWindow.performed -= m_Wrapper.m_GUIActionsCallbackInterface.OnStatWindow;
                StatWindow.canceled -= m_Wrapper.m_GUIActionsCallbackInterface.OnStatWindow;
            }
            m_Wrapper.m_GUIActionsCallbackInterface = instance;
            if (instance != null)
            {
                Inventory.started += instance.OnInventory;
                Inventory.performed += instance.OnInventory;
                Inventory.canceled += instance.OnInventory;
                QuestWindow.started += instance.OnQuestWindow;
                QuestWindow.performed += instance.OnQuestWindow;
                QuestWindow.canceled += instance.OnQuestWindow;
                PauseMenu.started += instance.OnPauseMenu;
                PauseMenu.performed += instance.OnPauseMenu;
                PauseMenu.canceled += instance.OnPauseMenu;
                StatWindow.started += instance.OnStatWindow;
                StatWindow.performed += instance.OnStatWindow;
                StatWindow.canceled += instance.OnStatWindow;
            }
        }
    }
    public GUIActions @GUI => new GUIActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_Item1;
    private readonly InputAction m_Inventory_Item2;
    private readonly InputAction m_Inventory_Item3;
    private readonly InputAction m_Inventory_Item4;
    private readonly InputAction m_Inventory_Item5;
    private readonly InputAction m_Inventory_Item6;
    private readonly InputAction m_Inventory_Item7;
    private readonly InputAction m_Inventory_Item8;
    private readonly InputAction m_Inventory_Item9;
    private readonly InputAction m_Inventory_Item10;
    public struct InventoryActions
    {
        private InputMaster m_Wrapper;
        public InventoryActions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Item1 => m_Wrapper.m_Inventory_Item1;
        public InputAction @Item2 => m_Wrapper.m_Inventory_Item2;
        public InputAction @Item3 => m_Wrapper.m_Inventory_Item3;
        public InputAction @Item4 => m_Wrapper.m_Inventory_Item4;
        public InputAction @Item5 => m_Wrapper.m_Inventory_Item5;
        public InputAction @Item6 => m_Wrapper.m_Inventory_Item6;
        public InputAction @Item7 => m_Wrapper.m_Inventory_Item7;
        public InputAction @Item8 => m_Wrapper.m_Inventory_Item8;
        public InputAction @Item9 => m_Wrapper.m_Inventory_Item9;
        public InputAction @Item10 => m_Wrapper.m_Inventory_Item10;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                Item1.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem1;
                Item1.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem1;
                Item1.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem1;
                Item2.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem2;
                Item2.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem2;
                Item2.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem2;
                Item3.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem3;
                Item3.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem3;
                Item3.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem3;
                Item4.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem4;
                Item4.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem4;
                Item4.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem4;
                Item5.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem5;
                Item5.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem5;
                Item5.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem5;
                Item6.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem6;
                Item6.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem6;
                Item6.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem6;
                Item7.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem7;
                Item7.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem7;
                Item7.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem7;
                Item8.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem8;
                Item8.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem8;
                Item8.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem8;
                Item9.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem9;
                Item9.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem9;
                Item9.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem9;
                Item10.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem10;
                Item10.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem10;
                Item10.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItem10;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                Item1.started += instance.OnItem1;
                Item1.performed += instance.OnItem1;
                Item1.canceled += instance.OnItem1;
                Item2.started += instance.OnItem2;
                Item2.performed += instance.OnItem2;
                Item2.canceled += instance.OnItem2;
                Item3.started += instance.OnItem3;
                Item3.performed += instance.OnItem3;
                Item3.canceled += instance.OnItem3;
                Item4.started += instance.OnItem4;
                Item4.performed += instance.OnItem4;
                Item4.canceled += instance.OnItem4;
                Item5.started += instance.OnItem5;
                Item5.performed += instance.OnItem5;
                Item5.canceled += instance.OnItem5;
                Item6.started += instance.OnItem6;
                Item6.performed += instance.OnItem6;
                Item6.canceled += instance.OnItem6;
                Item7.started += instance.OnItem7;
                Item7.performed += instance.OnItem7;
                Item7.canceled += instance.OnItem7;
                Item8.started += instance.OnItem8;
                Item8.performed += instance.OnItem8;
                Item8.canceled += instance.OnItem8;
                Item9.started += instance.OnItem9;
                Item9.performed += instance.OnItem9;
                Item9.canceled += instance.OnItem9;
                Item10.started += instance.OnItem10;
                Item10.performed += instance.OnItem10;
                Item10.canceled += instance.OnItem10;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.GetControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.GetControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnContinue(InputAction.CallbackContext context);
        void OnAnswerUp(InputAction.CallbackContext context);
        void OnAnswerDown(InputAction.CallbackContext context);
        void OnChooseAnswer(InputAction.CallbackContext context);
    }
    public interface IGUIActions
    {
        void OnInventory(InputAction.CallbackContext context);
        void OnQuestWindow(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnStatWindow(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnItem1(InputAction.CallbackContext context);
        void OnItem2(InputAction.CallbackContext context);
        void OnItem3(InputAction.CallbackContext context);
        void OnItem4(InputAction.CallbackContext context);
        void OnItem5(InputAction.CallbackContext context);
        void OnItem6(InputAction.CallbackContext context);
        void OnItem7(InputAction.CallbackContext context);
        void OnItem8(InputAction.CallbackContext context);
        void OnItem9(InputAction.CallbackContext context);
        void OnItem10(InputAction.CallbackContext context);
    }
}
