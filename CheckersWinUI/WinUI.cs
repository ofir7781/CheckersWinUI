﻿using System;

namespace CheckersWinUI
{
    public class WinUI
    {
        private SettingsForm m_SettingsForm;
        private GameForm m_GameForm;

        public void Run()
        {
            m_SettingsForm = new SettingsForm();
            m_SettingsForm.ShowDialog();
            m_GameForm = new GameForm(m_SettingsForm.BoardSize, m_SettingsForm.IsHumanPlayer2, m_SettingsForm.Player1Name, m_SettingsForm.Player2Name);
            m_GameForm.ShowDialog();
        }
    }
}
