using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShawarmitaF
{
    public class Comida
    {
        String name;
        Boolean lechuga;
        Boolean tomate;
        Boolean cebolla;

        Boolean grande;
        Boolean mediano;
        Boolean pequenio;

        Double precio;
        Image image;


        public Comida()
        {
            name = "";
            lechuga = false;
            tomate = false;
            cebolla = false;

            grande = false;
            pequenio = false;
            mediano = false;

            precio = 0;
            
        }

        
        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void setLechuga(Boolean lechu)
        {
            this.lechuga = lechu;
        }

        public void setTomate(Boolean tomat)
        {
            this.tomate = tomat;
        }

        public void setCebolla(Boolean ceboll)
        {
            this.cebolla = ceboll;
        }

        public void setPrecio(Double pre)
        {
            this.precio = pre;
        }

        public Boolean getLechuga()
        {
            return lechuga;
        }

        public Boolean getTomate()
        {
            return tomate;
        }

        public Boolean getCebolla()
        {
            return cebolla;
        }

        public Double getPrecio()
        {
            return precio;
        }

        public void setImage(Image ima)
        {
            this.image = ima;
        }

        public Image getImage()
        {
            return image;
        }


        public void setGrande(Boolean g)
        {
            this.grande = g;
        }
        public void setMediano(Boolean g)
        {
            this.mediano = g;
        }
        public void setPequenio(Boolean g)
        {
            this.pequenio = g;
        }

        public Boolean getGrande()
        {
            return grande;
        }

        public Boolean getMediano()
        {
            return mediano;
        }

        public Boolean getPequenio()
        {
            return pequenio;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }




    }
}
