
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ProyectoGru.Data
{

using System;
    using System.Collections.Generic;
    
public partial class Contenedor
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Contenedor()
    {

        this.ContenedorCodecAudios = new HashSet<ContenedorCodecAudio>();

        this.ContenedorCodecVideos = new HashSet<ContenedorCodecVideo>();

        this.ContenedorTranscoders = new HashSet<ContenedorTranscoder>();

    }


    public int IdContenedor { get; set; }

    public string Nombre { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ContenedorCodecAudio> ContenedorCodecAudios { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ContenedorCodecVideo> ContenedorCodecVideos { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ContenedorTranscoder> ContenedorTranscoders { get; set; }

}

}
