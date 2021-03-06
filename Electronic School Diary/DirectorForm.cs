﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicSchoolDiary
{
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        public void warning()
        {
            MessageBox.Show("Polja ne mogu biti prazna !");
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            CenterToParent();
            ControlBox = false;
            ChoseComboBox.SelectedIndex = 0;
        }

        private void LogOutUserButton_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Hide();
        }
        private string selectedUser()
        {
            return ChoseComboBox.Text;
        }

        private void ChoseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string current = selectedUser();
                if (current == "Administracija")
                {
                    AdminPanel.Show();
                    label2.Show();
                    ChoseComboBox.Show();
                    TeacherPanel.Hide();
                    StudentAndParentPanel.Hide();
                    DepartmentsPanel.Hide();
                    PasswordPanel.Hide();
                }
                if (current == "Nastavnici")
                {
                    TeacherPanel.Show();
                    label2.Show();
                    ChoseComboBox.Show();
                    StudentAndParentPanel.Hide();
                    AdminPanel.Hide();
                    DepartmentsPanel.Hide();
                    PasswordPanel.Hide();

                }
                if (current == "Učenici i roditelji")
                {
                    StudentAndParentPanel.Show();
                    label2.Show();
                    ChoseComboBox.Show();
                    AdminPanel.Hide();
                    TeacherPanel.Hide();
                    DepartmentsPanel.Hide();
                    PasswordPanel.Hide();
                }

                if (current == "Odjeljenja")
                {
                    DepartmentsPanel.Show();
                    label2.Show();
                    ChoseComboBox.Show();
                    AdminPanel.Hide();
                    TeacherPanel.Hide();
                    StudentAndParentPanel.Hide();
                    PasswordPanel.Hide();
                }
                if (current == "Izvještaji")
                {
                    AdminPanel.Hide();
                    label2.Show();
                    ChoseComboBox.Show();
                    TeacherPanel.Hide();
                    StudentAndParentPanel.Hide();
                    DepartmentsPanel.Hide();
                    PasswordPanel.Hide();
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            PasswordPanel.Show();
            AdminPanel.Hide();
            label2.Hide();
            ChoseComboBox.Hide();
            TeacherPanel.Hide();
            StudentAndParentPanel.Hide();
            DepartmentsPanel.Hide();
        }

        private void CertificateRoundedButton_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void ControlTableButton_Click(object sender, EventArgs e)
        {
            ChoseComboBox.SelectedIndex = 0;
            AdminPanel.Show();
            label2.Show();
            ChoseComboBox.Show();
            TeacherPanel.Hide();
            StudentAndParentPanel.Hide();
            DepartmentsPanel.Hide();
            PasswordPanel.Hide();
        }

        private void ChangeTeacherInfoButton_Click(object sender, EventArgs e)
        {
            if(
                TeacherNameTextBox.Text.Length == 0 ||
                TeacherSurnameTextBox.Text.Length == 0 )
            {
                warning();
            }
        }

        private void ChangeAdminInfoRoundedButton_Click(object sender, EventArgs e)
        {
            if(AdminNameTextBox.Text.Length == 0 || AdminSurnameTextBox.Text.Length ==0)
            {
                warning();
            }
        }

        private void AddDirectorPasswordButton_Click(object sender, EventArgs e)
        {
            if (OldPassTextBox.Text.Length == 0 ||
               NewPassTextBox.Text.Length == 0 ||
               ConfirmedNewPassTextBox.Text.Length == 0)
            {
                warning();
            }
        }
    }
}
