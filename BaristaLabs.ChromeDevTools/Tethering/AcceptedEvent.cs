namespace BaristaLabs.ChromeDevTools.Tethering
{
    /// <summary>
    /// Informs that port was successfully bound and got a specified connection id.
    /// </summary>
    public sealed class AcceptedEvent
    {
    
        
        /// <summary>
        /// Port number that was successfully bound.
        /// </summary>
        
        public long Port
        {
            get;
            set;
        }
    
        
        /// <summary>
        /// Connection id to be used.
        /// </summary>
        
        public string ConnectionId
        {
            get;
            set;
        }
    
    }
}