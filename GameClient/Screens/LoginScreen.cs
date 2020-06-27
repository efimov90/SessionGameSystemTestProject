using Godot;
using System;
using System.Diagnostics;

public class LoginScreen : Control
{
	private Label KeyboardLayoutLabel;
	private const string passwordEditPath = "LoginMenu/PasswordEdit";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//KeyboardLayoutLabel = GetNode<Label>("LoginMenu/PasswordLabelContainer/KeyboardLayout/KeyboardLayoutLabel");
		//UpdateKeyboardLayout();
	}

	private void UpdateKeyboardLayout()
	{
		KeyboardLayoutLabel.Text = OS.KeyboardGetLayoutLanguage(OS.KeyboardGetCurrentLayout()).Capitalize();
	}

	private void _on_LoginEdit_text_entered(String new_text)
	{
		GetNode<LineEdit>(passwordEditPath).GrabFocus();
	}

	private void _on_PasswordEdit_text_entered(String new_text)
	{
		
	}
}
