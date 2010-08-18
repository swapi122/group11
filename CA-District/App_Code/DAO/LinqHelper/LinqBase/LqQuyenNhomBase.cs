




/*
'===============================================================================
'  LinqHelper.DAO.QuyenNhomBase
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
	public class LqQuyenNhomBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuyenNhomBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqQuyenNhomEntity obj)
		{
			provider.GetTable<LqQuyenNhomEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqQuyenNhomEntity _obj)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqQuyenNhomEntity tmp = q.First<LqQuyenNhomEntity>();
			
			tmp.IdNhom = _obj.IdNhom;
			tmp.TenBang = _obj.TenBang;
			tmp.TenCot = _obj.TenCot;
			tmp.GiaTri = _obj.GiaTri;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqQuyenNhomEntity obj)
		{
			provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNhom(Guid IdNhom)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.IdNhom.Value == IdNhom
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenBang(string TenBang)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.TenBang == TenBang
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenCot(string TenCot)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.TenCot == TenCot
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGiaTri(string GiaTri)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.GiaTri == GiaTri
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqQuyenNhomEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqQuyenNhomEntity ob = (LqQuyenNhomEntity)q.First<LqQuyenNhomEntity>();
            provider.GetTable<LqQuyenNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqQuyenNhomEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqQuyenNhomEntity>();
		}

		public List<LqQuyenNhomEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByIdNhom(Guid IdNhom)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.IdNhom.Value == IdNhom
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByTenBang(string TenBang)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.TenBang == TenBang
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByTenCot(string TenCot)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.TenCot == TenCot
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByGiaTri(string GiaTri)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.GiaTri == GiaTri
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		public List<LqQuyenNhomEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqQuyenNhomEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqQuyenNhomEntity>();
		}
		
		
		

	}
}
