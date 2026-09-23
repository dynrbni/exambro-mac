const { contextBridge, ipcRenderer } = require('electron');

contextBridge.exposeInMainWorld('launcherAPI', {
  getSystem: () => ipcRenderer.invoke('system-info'),
  getCameras: () => ipcRenderer.invoke('cameras'),
  getConfig: () => ipcRenderer.invoke('get-config'),
  checkInternet: (url, timeoutMs) => ipcRenderer.invoke('check-internet', url, timeoutMs),
  startExam: (payload) => ipcRenderer.invoke('start-exam', payload),
  saveConfig: (payload) => ipcRenderer.invoke('save-config', payload),
  setWindowSize: (w, h) => ipcRenderer.invoke('window-resize', w, h),
  quit: () => ipcRenderer.send('app-quit'),
});