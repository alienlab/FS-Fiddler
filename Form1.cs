using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Alienlab.Tools.FSFiddler2
{
  public partial class Form1 : Form
  {
    private FileSystemWatcher fileSystemWatcher;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      cmdStart.Enabled = false;
      cmdStop.Enabled = true;
      txtPath.Enabled = false;
      txtFilter.Enabled = false;
      cbIncludeSubFolders.Enabled = false;
      this.Start();
    }

    private void Start()
    {
      fileSystemWatcher = new FileSystemWatcher
        {
          Filter = txtFilter.Text,
          Path = txtPath.Text,
          IncludeSubdirectories = cbIncludeSubFolders.Checked,
          NotifyFilter = NotifyFilters.DirectoryName | NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size
        };
      fileSystemWatcher.Changed += FileSystemWatcherChanged;
      fileSystemWatcher.Created += FileSystemWatcherChanged;
      fileSystemWatcher.Deleted += FileSystemWatcherChanged;
      fileSystemWatcher.Renamed += FileSystemWatcherChanged;
      fileSystemWatcher.Error += Error;
      fileSystemWatcher.EnableRaisingEvents = true;
    }

    private void Error(object sender, ErrorEventArgs e)
    {
      Append("ERROR\t" + (e.GetException().Message));
    }

    public delegate void MyDelegate();
    private void Append(string message)
    {
      var d = new MyDelegate(() => this.lbResults.Items.Insert(0, string.Format("{0}\t{1}", DateTime.Now.ToString(CultureInfo.InvariantCulture), message)));
      if (this.lbResults.InvokeRequired)
      {
        this.lbResults.Invoke(d);
      }
      else
      {
        d();
      }
    }

    void FileSystemWatcherChanged(object sender, FileSystemEventArgs e)
    {
      Append(e.ChangeType.ToString() + "\t\t" + e.FullPath);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      cmdStart.Enabled = true;
      cmdStop.Enabled = false;
      txtPath.Enabled = true;
      txtFilter.Enabled = true;
      cbIncludeSubFolders.Enabled = true;
      Stop();
    }

    private void Stop()
    {
      fileSystemWatcher.EnableRaisingEvents = false;
    }

    private void cmdClear_Click(object sender, EventArgs e)
    {
      lbResults.Items.Clear();
    }

    private void listBox1_DoubleClick(object sender, EventArgs e)
    {
      var text = (string)lbResults.SelectedItem;
      var p = text.LastIndexOf('\t');
      if (p > 0)
      {
        var path = text.Substring(p+1);
        if (Directory.Exists(path))
        {
          Process.Start(path);
        }
        else if(File.Exists(path))
        {
          Process.Start(Path.GetDirectoryName(path));
        }
      }
    }
  }
}
