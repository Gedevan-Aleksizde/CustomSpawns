﻿using System.Collections.Generic;
using CustomSpawns.Data.Model.Reward;
using CustomSpawns.Dialogues.DialogueAlgebra;

namespace CustomSpawns.Data.Dto
{
    public class DialogueDto
    {
        public DialogueType Type { get; set; }
        
        public string Text { get; set; }
        
        public string Id { get; set; }
        
        public DialogueCondition Condition { get; set; }
        
        public DialogueConsequence Consequence { get; set; }
        
        public bool IsPlayerDialogue { get; set; }
        
        public List<DialogueDto> Options { get; set; }
        
        public bool InjectedToTaleworlds { get; set; }
        
    }
}