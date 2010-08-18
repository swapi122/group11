




/*
'===============================================================================
'  LinqHelper.DAO.TienAnDoiTuongBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqTienAnDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTienAnDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTienAnDoiTuongEntity obj)
		{
			provider.GetTable<LqTienAnDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTienAnDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTienAnDoiTuongEntity tmp = q.First<LqTienAnDoiTuongEntity>();
			
			tmp.IdDoiTuong = _obj.IdDoiTuong;
			tmp.MaSuuTra = _obj.MaSuuTra;
			tmp.IdLoaiDoiTuong = _obj.IdLoaiDoiTuong;
			tmp.NgayBat = _obj.NgayBat;
			tmp.NgayTha = _obj.NgayTha;
			tmp.VaiTro = _obj.VaiTro;
			tmp.MucAn = _obj.MucAn;
			tmp.IdLoaiTienAn = _obj.IdLoaiTienAn;
			tmp.TongHop = _obj.TongHop;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqTienAnDoiTuongEntity obj)
		{
			provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.IdDoiTuong.Value == IdDoiTuong
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaSuuTra(string MaSuuTra)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.MaSuuTra == MaSuuTra
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.IdLoaiDoiTuong.Value == IdLoaiDoiTuong
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayBat(DateTime NgayBat)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.NgayBat.Value == NgayBat
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTha(DateTime NgayTha)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.NgayTha.Value == NgayTha
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByVaiTro(string VaiTro)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.VaiTro == VaiTro
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMucAn(string MucAn)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.MucAn == MucAn
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiTienAn(Guid IdLoaiTienAn)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.IdLoaiTienAn.Value == IdLoaiTienAn
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongHop(string TongHop)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.TongHop == TongHop
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTienAnDoiTuongEntity ob = (LqTienAnDoiTuongEntity)q.First<LqTienAnDoiTuongEntity>();
            provider.GetTable<LqTienAnDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTienAnDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTienAnDoiTuongEntity>();
		}

		public List<LqTienAnDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.IdDoiTuong.Value == IdDoiTuong
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByMaSuuTra(string MaSuuTra)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.MaSuuTra == MaSuuTra
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.IdLoaiDoiTuong.Value == IdLoaiDoiTuong
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByNgayBat(DateTime NgayBat)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.NgayBat.Value == NgayBat
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByNgayTha(DateTime NgayTha)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.NgayTha.Value == NgayTha
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByVaiTro(string VaiTro)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.VaiTro == VaiTro
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByMucAn(string MucAn)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.MucAn == MucAn
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByIdLoaiTienAn(Guid IdLoaiTienAn)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.IdLoaiTienAn.Value == IdLoaiTienAn
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByTongHop(string TongHop)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.TongHop == TongHop
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		public List<LqTienAnDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTienAnDoiTuongEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTienAnDoiTuongEntity>();
		}
		
		
		

	}
}
