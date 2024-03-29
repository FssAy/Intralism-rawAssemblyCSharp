﻿using System;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x02000489 RID: 1161
public static class FILE
{
	// Token: 0x06010A4D RID: 68173 RVA: 0x005A2DA0 File Offset: 0x005A0FA0
	public static string ReadText(string HAEBGHHMEBH)
	{
		if (File.Exists(HAEBGHHMEBH))
		{
			StreamReader streamReader = null;
			string result;
			try
			{
				StreamReader streamReader2;
				streamReader = (streamReader2 = new StreamReader(HAEBGHHMEBH, Encoding.UTF8));
				try
				{
					result = streamReader.ReadToEnd();
				}
				finally
				{
					if (streamReader2 != null)
					{
						((IDisposable)streamReader2).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				result = null;
			}
			finally
			{
				if (streamReader != null)
				{
					streamReader.Close();
				}
			}
			return result;
		}
		throw new IOException(string.Format("File not found: {0}", HAEBGHHMEBH));
	}

	// Token: 0x06010A4E RID: 68174 RVA: 0x005A2E40 File Offset: 0x005A1040
	public static Texture2D ReadTexture(string HAEBGHHMEBH)
	{
		if (File.Exists(HAEBGHHMEBH))
		{
			try
			{
				Texture2D texture2D = new Texture2D(0, 0);
				byte[] data = File.ReadAllBytes(HAEBGHHMEBH);
				if (!texture2D.LoadImage(data))
				{
					Debug.LogError(string.Format("Reading preview file failed!: \"{0}\"", HAEBGHHMEBH));
				}
				return texture2D;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				return null;
			}
		}
		Debug.LogError(string.Format("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", HAEBGHHMEBH));
		return null;
	}

	// Token: 0x06010A4F RID: 68175 RVA: 0x005A2EBC File Offset: 0x005A10BC
	public static bool WriteText(string HAEBGHHMEBH, string EAFAMAMDNEG)
	{
		StreamWriter streamWriter = null;
		bool result;
		try
		{
			if (File.Exists(HAEBGHHMEBH))
			{
				StreamWriter streamWriter2;
				streamWriter = (streamWriter2 = File.CreateText(HAEBGHHMEBH));
				try
				{
					streamWriter.Write(EAFAMAMDNEG);
				}
				finally
				{
					if (streamWriter2 != null)
					{
						((IDisposable)streamWriter2).Dispose();
					}
				}
				result = true;
			}
			else
			{
				StreamWriter streamWriter3;
				streamWriter = (streamWriter3 = File.CreateText(HAEBGHHMEBH));
				try
				{
					streamWriter.Write(EAFAMAMDNEG);
				}
				finally
				{
					if (streamWriter3 != null)
					{
						((IDisposable)streamWriter3).Dispose();
					}
				}
				result = true;
			}
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
			result = false;
		}
		finally
		{
			if (streamWriter != null)
			{
				streamWriter.Close();
			}
		}
		return result;
	}
}
